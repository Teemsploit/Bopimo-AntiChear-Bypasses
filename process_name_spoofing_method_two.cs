using System;
using System.Diagnostics;

class P {
    static void Main() {
        Console.Write("\x1b]0;cheat\x07");
        Console.WriteLine("Title is 'cheat'");
        Console.WriteLine("Process name: " + Process.GetCurrentProcess().ProcessName);
        Console.ReadLine();
    }
}
