using System;

namespace WinTail
{
    public interface IConsoleWriter
    {
        ConsoleColor ForegroundColor { get; set; }

        void ResetColor();
        void WriteLine(string v);
    }
}