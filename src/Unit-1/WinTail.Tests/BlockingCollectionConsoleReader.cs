using System.Collections.Concurrent;

namespace WinTail.Tests
{
    public class BlockingCollectionConsoleReader: IConsoleReader
    {
        private BlockingCollection<string> readQueue = new();

        public string ReadLine()
        {
            return readQueue.Take();
        }

        public void SetValue(string value)
        {
            readQueue.Add(value);
        }
    }
}