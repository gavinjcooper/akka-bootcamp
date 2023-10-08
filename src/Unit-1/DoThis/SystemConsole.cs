using System;

namespace WinTail
{
    internal class SystemConsole : IConsoleReader, IConsoleWriter
    {
        public ConsoleColor ForegroundColor
        {
            get => Console.ForegroundColor;
            set => Console.ForegroundColor = value;
        }

        public void ResetColor() => Console.ResetColor();

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}