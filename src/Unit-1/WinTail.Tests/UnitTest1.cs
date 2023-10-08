using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace WinTail.Tests
{
    [UsesVerify]
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var outputPrinter = new ConsolePrinter();
            var sut = new Application(outputPrinter);

            sut.Run(new string[] { });


        }
}