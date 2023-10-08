using System;
using Akka.Actor;

namespace WinTail
{
    public class Application
    {
        public ActorSystem MyActorSystem;
        private readonly IConsoleWriter consoleWriter;
        private readonly IConsoleReader consoleReader;

        public Application(IConsoleWriter consoleWriter, IConsoleReader consoleReader)
        {
            this.consoleWriter = consoleWriter;
            this.consoleReader = consoleReader;
        }

        public void Run(string[] args)
        {
            // initialize MyActorSystem
            MyActorSystem = ActorSystem.Create("MyActorSystem");

            PrintInstructions();

            // time to make your first actors!
            var consoleWriterActor = MyActorSystem.ActorOf(Props.Create(() => new ConsoleWriterActor(consoleWriter)));
            var consoleReaderActor = MyActorSystem.ActorOf(Props.Create(() => new ConsoleReaderActor(consoleWriterActor, consoleReader)));

            // tell console reader to begin
            consoleReaderActor.Tell(ConsoleReaderActor.StartCommand);

            // blocks the main thread from exiting until the actor system is shut down
            MyActorSystem.WhenTerminated.Wait();
        }

        private static void PrintInstructions()
        {
            Console.WriteLine("Write whatever you want into the console!");
            Console.Write("Some lines will appear as");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" red ");
            Console.ResetColor();
            Console.Write(" and others will appear as");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" green! ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Type 'exit' to quit this application at any time.\n");
        }
    }
}
