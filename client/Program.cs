using popup;
using System;

namespace client
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Start Client");

            var wpfApp1 = new App();
            wpfApp1.Run();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
