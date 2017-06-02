using CuteAnt.AsyncEx;

namespace System.Threading.Tasks
{
  /// <summary>Provides extension methods for task factories.</summary>
  internal static class CaTaskFactoryExtensions
  {
    #region -- StartNew --

    internal static Task StartNew<T1>(this TaskFactory @this,
      Action<T1> action, T1 arg1,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Action<T1>, T1>)state;
        wrapper.Item1.Invoke(wrapper.Item2);
      }, Tuple.Create(action, arg1), cancellationToken, creationOptions, scheduler);
    }
    internal static Task StartNew<T1, T2>(this TaskFactory @this,
      Action<T1, T2> action, T1 arg1, T2 arg2,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Action<T1, T2>, T1, T2>)state;
        wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3);
      }, Tuple.Create(action, arg1, arg2), cancellationToken, creationOptions, scheduler);
    }
    internal static Task StartNew<T1, T2, T3>(this TaskFactory @this,
      Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Action<T1, T2, T3>, T1, T2, T3>)state;
        wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4);
      }, Tuple.Create(action, arg1, arg2, arg3), cancellationToken, creationOptions, scheduler);
    }
    internal static Task StartNew<T1, T2, T3, T4>(this TaskFactory @this,
      Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Action<T1, T2, T3, T4>, T1, T2, T3, T4>)state;
        wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5);
      }, Tuple.Create(action, arg1, arg2, arg3, arg4), cancellationToken, creationOptions, scheduler);
    }
    internal static Task StartNew<T1, T2, T3, T4, T5>(this TaskFactory @this,
      Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Action<T1, T2, T3, T4, T5>, T1, T2, T3, T4, T5>)state;
        wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5, wrapper.Item6);
      }, Tuple.Create(action, arg1, arg2, arg3, arg4, arg5), cancellationToken, creationOptions, scheduler);
    }
    internal static Task StartNew<T1, T2, T3, T4, T5, T6>(this TaskFactory @this,
      Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Action<T1, T2, T3, T4, T5, T6>, T1, T2, T3, T4, T5, T6>)state;
        wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5, wrapper.Item6, wrapper.Item7);
      }, Tuple.Create(action, arg1, arg2, arg3, arg4, arg5, arg6), cancellationToken, creationOptions, scheduler);
    }




    internal static Task StartNew<T1>(this TaskFactory @this,
      Func<T1, Task> action, T1 arg1,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, Task>, T1>)state;
        return wrapper.Item1.Invoke(wrapper.Item2);
      }, Tuple.Create(action, arg1), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task StartNew<T1, T2>(this TaskFactory @this,
      Func<T1, T2, Task> action, T1 arg1, T2 arg2,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, Task>, T1, T2>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3);
      }, Tuple.Create(action, arg1, arg2), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task StartNew<T1, T2, T3>(this TaskFactory @this,
      Func<T1, T2, T3, Task> action, T1 arg1, T2 arg2, T3 arg3,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, Task>, T1, T2, T3>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4);
      }, Tuple.Create(action, arg1, arg2, arg3), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task StartNew<T1, T2, T3, T4>(this TaskFactory @this,
      Func<T1, T2, T3, T4, Task> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, Task>, T1, T2, T3, T4>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5);
      }, Tuple.Create(action, arg1, arg2, arg3, arg4), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task StartNew<T1, T2, T3, T4, T5>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, Task> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, T5, Task>, T1, T2, T3, T4, T5>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5, wrapper.Item6);
      }, Tuple.Create(action, arg1, arg2, arg3, arg4, arg5), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task StartNew<T1, T2, T3, T4, T5, T6>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, T6, Task> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (action == null) throw new ArgumentNullException(nameof(action));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, T5, T6, Task>, T1, T2, T3, T4, T5, T6>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5, wrapper.Item6, wrapper.Item7);
      }, Tuple.Create(action, arg1, arg2, arg3, arg4, arg5, arg6), cancellationToken, creationOptions, scheduler).Unwrap();
    }




    internal static Task<TResult> StartNew<T1, TResult>(this TaskFactory @this,
      Func<T1, TResult> function, T1 arg1,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, TResult>, T1>)state;
        return wrapper.Item1.Invoke(wrapper.Item2);
      }, Tuple.Create(function, arg1), cancellationToken, creationOptions, scheduler);
    }
    internal static Task<TResult> StartNew<T1, T2, TResult>(this TaskFactory @this,
      Func<T1, T2, TResult> function, T1 arg1, T2 arg2,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, TResult>, T1, T2>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3);
      }, Tuple.Create(function, arg1, arg2), cancellationToken, creationOptions, scheduler);
    }
    internal static Task<TResult> StartNew<T1, T2, T3, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, TResult> function, T1 arg1, T2 arg2, T3 arg3,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, TResult>, T1, T2, T3>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4);
      }, Tuple.Create(function, arg1, arg2, arg3), cancellationToken, creationOptions, scheduler);
    }
    internal static Task<TResult> StartNew<T1, T2, T3, T4, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, TResult>, T1, T2, T3, T4>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5);
      }, Tuple.Create(function, arg1, arg2, arg3, arg4), cancellationToken, creationOptions, scheduler);
    }
    internal static Task<TResult> StartNew<T1, T2, T3, T4, T5, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, T5, TResult>, T1, T2, T3, T4, T5>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5, wrapper.Item6);
      }, Tuple.Create(function, arg1, arg2, arg3, arg4, arg5), cancellationToken, creationOptions, scheduler);
    }
    internal static Task<TResult> StartNew<T1, T2, T3, T4, T5, T6, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, T5, T6, TResult>, T1, T2, T3, T4, T5, T6>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5, wrapper.Item6, wrapper.Item7);
      }, Tuple.Create(function, arg1, arg2, arg3, arg4, arg5, arg6), cancellationToken, creationOptions, scheduler);
    }




    internal static Task<TResult> StartNew<T1, TResult>(this TaskFactory @this,
      Func<T1, Task<TResult>> function, T1 arg1,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, Task<TResult>>, T1>)state;
        return wrapper.Item1.Invoke(wrapper.Item2);
      }, Tuple.Create(function, arg1), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task<TResult> StartNew<T1, T2, TResult>(this TaskFactory @this,
      Func<T1, T2, Task<TResult>> function, T1 arg1, T2 arg2,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, Task<TResult>>, T1, T2>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3);
      }, Tuple.Create(function, arg1, arg2), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task<TResult> StartNew<T1, T2, T3, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, Task<TResult>> function, T1 arg1, T2 arg2, T3 arg3,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, Task<TResult>>, T1, T2, T3>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4);
      }, Tuple.Create(function, arg1, arg2, arg3), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task<TResult> StartNew<T1, T2, T3, T4, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, Task<TResult>> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, Task<TResult>>, T1, T2, T3, T4>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5);
      }, Tuple.Create(function, arg1, arg2, arg3, arg4), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task<TResult> StartNew<T1, T2, T3, T4, T5, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, Task<TResult>> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, T5, Task<TResult>>, T1, T2, T3, T4, T5>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5, wrapper.Item6);
      }, Tuple.Create(function, arg1, arg2, arg3, arg4, arg5), cancellationToken, creationOptions, scheduler).Unwrap();
    }
    internal static Task<TResult> StartNew<T1, T2, T3, T4, T5, T6, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, T6, Task<TResult>> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
      CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
    {
      if (@this == null) throw new ArgumentNullException(nameof(@this));
      if (function == null) throw new ArgumentNullException(nameof(function));

      return @this.StartNew(state =>
      {
        var wrapper = (Tuple<Func<T1, T2, T3, T4, T5, T6, Task<TResult>>, T1, T2, T3, T4, T5, T6>)state;
        return wrapper.Item1.Invoke(wrapper.Item2, wrapper.Item3, wrapper.Item4, wrapper.Item5, wrapper.Item6, wrapper.Item7);
      }, Tuple.Create(function, arg1, arg2, arg3, arg4, arg5, arg6), cancellationToken, creationOptions, scheduler).Unwrap();
    }

    #endregion

    #region -- Run --

    internal static Task Run<T1>(this TaskFactory @this,
      Action<T1> action, T1 arg1,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2>(this TaskFactory @this,
      Action<T1, T2> action, T1 arg1, T2 arg2,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2, T3>(this TaskFactory @this,
      Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, arg3, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2, T3, T4>(this TaskFactory @this,
      Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, arg3, arg4, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2, T3, T4, T5>(this TaskFactory @this,
      Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, arg3, arg4, arg5, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2, T3, T4, T5, T6>(this TaskFactory @this,
      Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, arg3, arg4, arg5, arg6, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }




    internal static Task Run<T1>(this TaskFactory @this,
      Func<T1, Task> action, T1 arg1,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2>(this TaskFactory @this,
      Func<T1, T2, Task> action, T1 arg1, T2 arg2,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2, T3>(this TaskFactory @this,
      Func<T1, T2, T3, Task> action, T1 arg1, T2 arg2, T3 arg3,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, arg3, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2, T3, T4>(this TaskFactory @this,
      Func<T1, T2, T3, T4, Task> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, arg3, arg4, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2, T3, T4, T5>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, Task> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, arg3, arg4, arg5, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task Run<T1, T2, T3, T4, T5, T6>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, T6, Task> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, action, arg1, arg2, arg3, arg4, arg5, arg6, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }




    internal static Task<TResult> Run<T1, TResult>(this TaskFactory @this,
      Func<T1, TResult> function, T1 arg1,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, TResult>(this TaskFactory @this,
      Func<T1, T2, TResult> function, T1 arg1, T2 arg2,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, T3, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, TResult> function, T1 arg1, T2 arg2, T3 arg3,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, arg3, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, T3, T4, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, arg3, arg4, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, T3, T4, T5, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, arg3, arg4, arg5, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, T3, T4, T5, T6, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, arg3, arg4, arg5, arg6, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }




    internal static Task<TResult> Run<T1, TResult>(this TaskFactory @this,
      Func<T1, Task<TResult>> function, T1 arg1,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, TResult>(this TaskFactory @this,
      Func<T1, T2, Task<TResult>> function, T1 arg1, T2 arg2,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, T3, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, Task<TResult>> function, T1 arg1, T2 arg2, T3 arg3,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, arg3, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, T3, T4, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, Task<TResult>> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, arg3, arg4, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, T3, T4, T5, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, Task<TResult>> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, arg3, arg4, arg5, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }
    internal static Task<TResult> Run<T1, T2, T3, T4, T5, T6, TResult>(this TaskFactory @this,
      Func<T1, T2, T3, T4, T5, T6, Task<TResult>> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
      CancellationToken cancellationToken = default(CancellationToken))
    {
      return StartNew(@this, function, arg1, arg2, arg3, arg4, arg5, arg6, cancellationToken,
          AsyncUtils.GetCreationOptions(@this.CreationOptions), @this.Scheduler ?? TaskScheduler.Default);
    }

    #endregion
  }
}