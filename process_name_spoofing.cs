using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class P {
    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();
    [DllImport("user32.dll")]
    static extern bool SetWindowText(IntPtr hWnd, string text);

    static void Main() {
        SetWindowText(GetConsoleWindow(), "cheat");
        Console.WriteLine("Title is 'cheat'");
        Console.WriteLine("Process name: " + Process.GetCurrentProcess().ProcessName);
        Console.ReadLine();
    }
}
