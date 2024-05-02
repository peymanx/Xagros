using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using Xagros.GUI;
using Sys = Cosmos.System;

namespace Xagros
{
    public class Kernel : Sys.Kernel
    {
        public static string Version { get; set; } = "1.0.0";
        public const string DefaultPtompt = " 0:\\>";
        public string Prompt { get; set; } = DefaultPtompt;

        public static Canvas Canvas;
        public static PCScreenFont DefaultFont { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        [ManifestResourceStream(ResourceName = "Xagros.Assets.Images.folder.bmp")]
        static byte[] FolderByte;
        public static Bitmap Folder;

        [ManifestResourceStream(ResourceName = "Xagros.Assets.Images.close_max_min_buttons.bmp")]
        static byte[] CloseByte;
        public static Bitmap CloseButton;



        protected override void BeforeRun()
        {
            Console.Clear();


            Console.WriteLine(@"
ooooooo  ooooo                                                  
 `XXXX    sX'                                                   
   YXXX..XP     .oooo.    .oooooooo oooo rr  .ooooo.   .oooo.o 
    `XXXX'     `P  )XXb  XXX' `XXb  `XXX''XP sXX' `XXb sXX(  'X 
   .XPYXXX.     .oP'XXX  XXX   XXX   XXX     XXX   XXX `'YXXb.  
  sX'  `XXXb   sX(  XXX  `PEYMANX'   XXX     XXX   XXX o.  )XXb 
oXXXo  oXXXXXo `YXXX''Xo `Xoooooo.  sXXXb    `YXbosXP' X''XXXP' 
                         s'     Ys                              
                         'YXXXXXP'                                                        
");
            Console.WriteLine($"Version {Version}");

            //init
            DefaultFont = PCScreenFont.Default;
            Folder = new(FolderByte);
            CloseButton = new(CloseByte);

        }

        protected override void Run()
        {
            Console.Write(Prompt + " ");
            var input = Console.ReadLine();
            var commands = input.Split(' ');
            if (commands.Length == 1)
            {
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

                    case "color": // with no argument; restore to default color (white!)
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case "prompt": // with no argument; restore to default
                        Prompt = DefaultPtompt;
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

                    case "tarikh":
                    case "jcal":
                        DateTime d = DateTime.Now;
                        PersianCalendar pc = new PersianCalendar();
                        Console.WriteLine(string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d)));
                        break;

                    case "clock":
                    case "time":
                        Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                        break;


                    case "win":
                    case "window":
                    case "windows":
                    case "graphic":
                    case "startx":
                    case "x":

                        Canvas = FullScreenCanvas.GetFullScreenCanvas();
                        Width = Canvas.Mode.Columns;
                        Height = Canvas.Mode.Rows;
                        Canvas.Clear(Color.Teal);
                        StartX();
                        break;

                    default: // Any other entries
                        Console.WriteLine("Command not found");
                        break;

                }
            }
            else
            {
                var command = commands[0];
                var args = string.Join(" ", commands.Skip(1));
                switch (command)
                {
                    case "echo":
                        Console.WriteLine(args);
                        break;

                    case "prompt":
                        Prompt = args;
                        break;

                    case "color":
                        switch (args)
                        {
                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red; break;
                            case "green":
                                Console.ForegroundColor = ConsoleColor.Green; break;
                            case "yellow":
                                Console.ForegroundColor = ConsoleColor.Yellow; break;
                            case "white":
                                Console.ForegroundColor = ConsoleColor.White; break;
                            default:

                                break;
                        }
                        break;


                    default:
                        break;

                }
            }
        }
        private void StartX()
        {
            try
            {
                new Window(200 - 50, 200 - 50, 700, 350, "peymanx", "File  Edit  View  Help");
                new Window(200 - 25, 200 - 25, 700, 400, "Program Files", "File  Edit  View  Help");
                new Window(200, 200, 700, 400, "Windows", "File  Edit  View  Help");

                // Taskbar
                Canvas.DrawFilledRectangle(new Pen(Color.White), 0, Height - 27, Width, 27);
                Canvas.DrawFilledRectangle(new Pen(Color.LightGray), 0, Height - 25, Width, 25);
                Canvas.DrawString($"start", DefaultFont, new Pen(Color.Black), 10, Height - 20);
                Canvas.DrawString(DateTime.Now.ToString("HH:mm"), DefaultFont, new Pen(Color.Black), Width - 50, Height - 20);

                Kernel.Canvas.Display();

                Console.ReadKey();
                //StartX();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Got fatal exception {e.Message}");
            }
        }
        private void Sunset()
        {
            try
            {
                // sunset
                Canvas.DrawFilledCircle(new Pen(Color.Red), Width / 2, Height / 2 - 50, 270);

                Canvas.DrawFilledRectangle(new Pen(Color.DarkViolet), 0, Height / 2, Width, Height);

                var horizon = Height / 2;
                for (int i = 0; i < 20; i++)
                {
                    horizon += i * 3;
                    Canvas.DrawLine(new Pen(Color.Yellow), 0, horizon, Width, horizon);

                }

                var vorizon = Width / 2;
                for (int i = 0; i < Width; i += 30)
                {
                    var gap = i * 4;
                    Canvas.DrawLine(new Pen(Color.Yellow, 6), vorizon + i, Height / 2, vorizon + gap, Height);
                    Canvas.DrawLine(new Pen(Color.Yellow, 6), vorizon - i, Height / 2, vorizon - gap, Height);
                }

                Canvas.Display();

                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Got fatal exception {e.Message}");
            }
        }


    }
}
