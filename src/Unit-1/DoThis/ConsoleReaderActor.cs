using System;
using Akka.Actor;

namespace WinTail
{
    /// <summary>
    /// Actor responsible for reading FROM the console. 
    /// Also responsible for calling <see cref="ActorSystem.Terminate"/>.
    /// </summary>
    class ConsoleReaderActor : UntypedActor
    {
        public const string StartCommand = "start";
        public const string ExitCommand = "exit";
        private IActorRef _consoleWriterActor;

        public ConsoleReaderActor(IActorRef consoleWriterActor)
        {
            _consoleWriterActor = consoleWriterActor;
        }

        protected override void OnReceive(object message)
        {
            if (message.Equals(StartCommand))
            {
                DoPrintInstructions();
            }
            else if (message is Messages.InputError e)
            {
                _consoleWriterActor.Tell(e);
            }

            GetAndValidateInput();

            //https://github.com/petabridge/akka-bootcamp/blob/master/src/Unit-1/lesson2/README.md#update-consolereaderactor
        }

        private void GetAndValidateInput()
        {
            throw new NotImplementedException();
        }

        private void DoPrintInstructions()
        {
            throw new NotImplementedException();
        }
    }
}