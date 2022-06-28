using System;

namespace TilfeldigeFirkanter
{
    class Program
    {
        static void Main(string[] args)
        {
            var virtualScreen = new VirtualScreen(40, 20);
            while (true)
            {
                virtualScreen.AddRandomBox();
                virtualScreen.Show();
                Console.WriteLine("(press enter for new. ctrl+c=exit)");
                Console.ReadLine();
            }
        }
    }
}
