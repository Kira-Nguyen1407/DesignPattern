using System;

namespace CommandPattern
{
    public class Program{
        static void Main(string[] args)
        {
            Invoker invoker = new();
            invoker.SetOnStart(new SimpleCommand("Say hi!"));

            Receiver receiver = new();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send Email", "Save reports"));

            invoker.DoSomethingImportant();
        }
    }
}