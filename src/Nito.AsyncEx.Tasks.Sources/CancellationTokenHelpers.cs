﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CuteAnt.AsyncEx
{
	/// <summary>Helper methods for cancellation tokens.</summary>
	internal static class CancellationTokenHelpers
	{
		/// <summary>Initializes the static members.</summary>
		static CancellationTokenHelpers()
		{
			Canceled = new CancellationToken(true);
		}

		/// <summary>Gets <see cref="CancellationToken.None"/>, a cancellation token that is never canceled.</summary>
		internal static CancellationToken None { get { return CancellationToken.None; } }

		/// <summary>Gets a cancellation token that is already canceled.</summary>
		internal static CancellationToken Canceled { get; private set; }

		/// <summary>Creates a cancellation token that is canceled after the due time.</summary>
		/// <param name="dueTime">The due time after which to cancel the token.</param>
		/// <returns>A cancellation token that is canceled after the due time.</returns>
		internal static NormalizedCancellationToken Timeout(TimeSpan dueTime)
		{
			var cts = new CancellationTokenSource();
			cts.CancelAfter(dueTime);
			return new NormalizedCancellationToken(cts);
		}

		/// <summary>Creates a cancellation token that is canceled after the due time.</summary>
		/// <param name="dueTime">The due time after which to cancel the token.</param>
		/// <returns>A cancellation token that is canceled after the due time.</returns>
		internal static NormalizedCancellationToken Timeout(Int32 dueTime)
		{
			var cts = new CancellationTokenSource();
			cts.CancelAfter(dueTime);
			return new NormalizedCancellationToken(cts);
		}

		/// <summary>Reduces a set of cancellation tokens by removing any cancellation tokens that cannot be canceled. 
		/// If any tokens are already canceled, the returned token will be canceled.</summary>
		/// <param name="cancellationTokens">The cancellation tokens to reduce.</param>
		internal static NormalizedCancellationToken Normalize(params CancellationToken[] cancellationTokens)
		{
			return Normalize((IEnumerable<CancellationToken>)cancellationTokens);
		}

		/// <summary>Reduces a set of cancellation tokens by removing any cancellation tokens that cannot be canceled. 
		/// If any tokens are already canceled, the returned token will be canceled.</summary>
		/// <param name="cancellationTokens">The cancellation tokens to reduce.</param>
		internal static NormalizedCancellationToken Normalize(IEnumerable<CancellationToken> cancellationTokens)
		{
			var tokens = cancellationTokens.Where(t => t.CanBeCanceled).ToArray();
			if (tokens.Length == 0) { return new NormalizedCancellationToken(); }
			if (tokens.Length == 1) { return new NormalizedCancellationToken(tokens[0]); }
			var alreadyCanceled = tokens.FirstOrDefault(t => t.IsCancellationRequested);
			if (alreadyCanceled.IsCancellationRequested) { return new NormalizedCancellationToken(alreadyCanceled); }
			return new NormalizedCancellationToken(CancellationTokenSource.CreateLinkedTokenSource(tokens));
		}

		/// <summary>Creates a cancellation token that is canceled when the provided <see cref="Task"/> completes.</summary>
		/// <param name="source">The task to observe.</param>
		/// <param name="continuationOptions">The options to use for the task continuation.</param>
		internal static NormalizedCancellationToken FromTask(Task source, TaskContinuationOptions continuationOptions)
		{
			var cts = new CancellationTokenSource();
#if !NET40
			source.ContinueWith((task, state) => ((CancellationTokenSource)state).Cancel(), cts, CancellationToken.None, continuationOptions, TaskScheduler.Default);
#else
			source.ContinueWith(_ => cts.Cancel(), CancellationToken.None, continuationOptions, TaskScheduler.Default);
#endif
			return new NormalizedCancellationToken(cts);
		}

		/// <summary>Creates a cancellation token that is canceled when the provided <see cref="Task"/> completes.</summary>
		/// <param name="source">The task to observe.</param>
		internal static NormalizedCancellationToken FromTask(Task source)
		{
			return FromTask(source, TaskContinuationOptions.None);
		}
	}
}