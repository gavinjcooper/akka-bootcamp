using System;
using Akka.Actor;

namespace WinTail
{
    /// <summary>
    /// Actor responsible for serializing message writes to the console.
    /// (write one message at a time, champ :)
    /// </summary>
    class ConsoleWriterActor : UntypedActor
    {
        private IConsoleWriter consoleWriter;

        public ConsoleWriterActor(IConsoleWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
        }

        protected override void OnReceive(object message)
        {
            if (message is Messages.InputError)
            {
                var msg = message as Messages.InputError;
                consoleWriter.ForegroundColor = ConsoleColor.Red;
                consoleWriter.WriteLine(msg.Reason);
            }
            else if (message is Messages.InputSuccess)
            {
                var msg = message as Messages.InputSuccess;
                consoleWriter.ForegroundColor = ConsoleColor.Green;
                consoleWriter.WriteLine(msg.Reason);
            }
            else
            {
                consoleWriter.WriteLine(message);
            }

            Console.ResetColor();
        }
    }
}
