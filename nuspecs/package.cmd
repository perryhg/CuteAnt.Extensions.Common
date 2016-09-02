SET /P VERSION_SUFFIX=Please enter version-suffix (can be left empty): 

dotnet "pack" "..\src\AspNetWebStack.Common.Collection.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\AspNetWebStack.Common.TaskExtensions.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\BitManipulator.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CmdLine.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CoreFX.Common.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.ActivatorUtilities.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.Async.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.ClosedGenericMatcher.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.CopyOnWriteDictionary.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.DateTimeUtilities.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.HashCodeCombiner.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.IO.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.Logging.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.LoggingServiceProvider.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.PropertyActivator.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.PropertyHelper.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.Reflection.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.Security.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.SecurityHelper.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.TaskAwaiter.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\CuteAnt.Extensions.TypeNameHelper.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\Nito.AsyncEx.ExceptionEnlightenment.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\Nito.AsyncEx.Tasks.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\RingBuffer.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\System.ServiceModel.HashHelper.Sources" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
dotnet "pack" "..\src\System.ServiceModel.Internals.Interop" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"
