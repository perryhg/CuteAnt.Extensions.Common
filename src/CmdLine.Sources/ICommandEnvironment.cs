namespace CmdLine
{
  internal interface ICommandEnvironment
  {
    string CommandLine { get; }

    string[] GetCommandLineArgs();

    string Program { get; }
  }
}