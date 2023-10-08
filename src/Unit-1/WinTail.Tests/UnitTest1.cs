using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Text;

namespace WinTail.Tests
{
    [UsesVerify]
    public class UnitTest1 : IConsoleReader
    {
        private ManualResetEventSlim handle = new ManualResetEventSlim(false);
        private string value = "testing";
        
        public string ReadLine()
        {
            handle.Wait();
            handle.Reset();

            return value;
        }

        private void SetValue(string value)
        {
            this.value = value;
            handle.Set();
        }

        [Fact]
        public async Task Test1()
        {
            var outputPrinter = new ConsolePrinter();
            var sut = new Application(outputPrinter, this);

            var actTask = Task.Run(() => sut.Run(new string[] { }));
            SetValue("test");

            await Task.Delay(1000);
            SetValue("exit");

            await actTask;

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