using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Xagros
{
    public class Kernel : Sys.Kernel
    {
        public static string Version { get; set; } = "1.0.0";
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine($"Xagros {Kernel.Version}");
        }

        protected override void Run()
        {
            Console.Write(" 0:\\> ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "":
                    break;

                case "about":
                    Console.WriteLine(@"Programmer: 
	Peyman Majidi Moein aka peymanx
Channels:
	aparat.com/peyman.majidi
	youtube.com/@peymanx

Free to use
For learning purpose
realated to a Youtube video
Source Code:
	github.com/peymanx
");
                    break;

                case "varsion":
                case "ver":
                    Console.WriteLine("Version " + Version);
                    break;

                case "help":
                    // TODO
                    // user manual
                    Console.WriteLine("Go to hell");
                    break;

                case "halt":
                case "shutdown":
                case "off":
                    Sys.Power.Shutdown();
                    break;

                case "reset":
                case "reboot":
                    Sys.Power.Reboot();
                    break;

                case "cls":
                case "clear":
                case "pak":
                    Console.Clear();
                    break;

                case "date":
                case "cal":
                    Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd"));
                    break;

                case "clock":
                case "time":
                    Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                    break;

                default: // Any other entries
                    Console.WriteLine("Command not found");
                    break;

            }
        }
    }
}
