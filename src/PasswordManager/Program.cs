using System;
using PasswordManager.Commands;

namespace PasswordManager
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var commandName = args[0];
                var commandBuilder = new CommandBuilder();

                for (var i = 2; i < args.Length; i += 2)
                {
                    commandBuilder.SetParam(args[i - 1][1..], args[i]);
                }

                commandBuilder.SetCommand(commandName);

                var command = commandBuilder.Build();

                if (command != null)
                {
                    command.Execute();
                }
                else
                {
                    Console.WriteLine($"wrong command name: {commandName}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured while executing command: {e.Message}");
            }
        }
    }
}