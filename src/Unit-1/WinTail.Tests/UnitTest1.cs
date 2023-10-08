using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections;
using System.Text;

namespace WinTail.Tests
{

    [UsesVerify]
    public class UnitTest1 : IAsyncLifetime
    {
        private ConsolePrinter outputPrinter;
        private BlockingCollectionConsoleReader consoleReader;
        private Task sut;

        public UnitTest1()
        {
            outputPrinter = new ConsolePrinter();
            consoleReader = new BlockingCollectionConsoleReader();

            sut = Task.Run(() => new Application(outputPrinter, consoleReader).Run(new string[] { }));
        }

        public async Task DisposeAsync()
        {
            consoleReader.SetValue("exit");
            await sut;
        }

        public Task InitializeAsync()
        {           
            return Task.CompletedTask;
        }

        [Fact]
        public async Task Test1()
        {
            consoleReader.SetValue("valid!");
            consoleReader.SetValue("invalid");

            await Task.Delay(1000);
            await Verifier.Verify(outputPrinter.ToString());
        }
    }

    internal class ConsolePrinter : IConsoleWriter
    {
        StringBuilder sb = new StringBuilder(); 

        public ConsoleColor ForegroundColor { get; set; }

        public void ResetColor()
        {
            throw new NotImplementedException();
        }

        public void WriteLine(object v)
        {
            sb.AppendLine(v.ToString());
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}