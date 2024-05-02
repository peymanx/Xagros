using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Xagros
{
    public class Music
    {

        public static void StartUpSound()
        {
            Console.Beep(300, 200);
            Thread.Sleep(50);
            Console.Beep(400, 100);
            Thread.Sleep(20);
            Console.Beep(500, 100);
            Thread.Sleep(20);
            Console.Beep(600, 100);
            Thread.Sleep(20);
            Console.Beep(700, 100);
            Thread.Sleep(30);

        }

        public static void HappyBirthDay()
        {
            // I have found these frequency values somewhere on the web with Google,
            // but I don't remember where exactly.
            int C = 264;
            int D = 297;
            int E = 330;
            int F = 352;
            int G = 396;
            int A = 440;
            int Bb = 466;
            int B = 495;
            int C2 = 528;

            // Now, we need to set the tempo for a note, half note, quarter note, and eighth note.
            int note = 1000;
            int half = 1000 / 2;
            int quarter = 1000 / 4;
            int eighth = 1000 / 6;

            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, half);
            Thread.Sleep(eighth);
            Console.Beep(C, half);
            Thread.Sleep(eighth);
            Console.Beep(F, half);
            Thread.Sleep(eighth);
            Console.Beep(E, note);
            Thread.Sleep(quarter);

            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, half);
            Thread.Sleep(eighth);
            Console.Beep(C, half);
            Thread.Sleep(eighth);
            Console.Beep(G, half);
            Thread.Sleep(eighth);
            Console.Beep(F, note);

            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(C2, half);
            Thread.Sleep(eighth);
            Console.Beep(A, half);
            Thread.Sleep(eighth);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);
            Console.Beep(F, eighth);
            Thread.Sleep(eighth);
            Console.Beep(E, half);
            Thread.Sleep(eighth);
            Console.Beep(D, note);

            Thread.Sleep(quarter);
            Console.Beep(Bb, eighth);
            Thread.Sleep(quarter);
            Console.Beep(Bb, eighth);
            Thread.Sleep(eighth);
            Console.Beep(A, half);
            Thread.Sleep(eighth);
            Console.Beep(F, half);
            Thread.Sleep(eighth);
            Console.Beep(G, half);
            Thread.Sleep(eighth);
            Console.Beep(F, note);

        }

        public static void Viva()
        {


            int note = 1000;
            int half = 1000 / 4;
            int quarter = 1000 / 6;
            int eighth = 1000 / 12;

            var f = 300;
            Console.Beep(f, quarter);
            Thread.Sleep(quarter);

            Console.Beep(f, eighth);
            Thread.Sleep(eighth);
            Console.Beep(f, eighth);
            Thread.Sleep(eighth);

            Console.Beep(f, quarter);
            Thread.Sleep(quarter);
            Console.Beep(f, quarter);
            Thread.Sleep(quarter);


            Console.Beep(f, note);
            Thread.Sleep(note);
        }


        public static void SuperMario()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            // ASCII text
            string text1 = @"
███████ ██    ██ ██████  ███████ ██████      ███    ███  █████  ██████  ██  ██████  
██      ██    ██ ██   ██ ██      ██   ██     ████  ████ ██   ██ ██   ██ ██ ██    ██ 
███████ ██    ██ ██████  █████   ██████      ██ ████ ██ ███████ ██████  ██ ██    ██ 
     ██ ██    ██ ██      ██      ██   ██     ██  ██  ██ ██   ██ ██   ██ ██ ██    ██ 
███████  ██████  ██      ███████ ██   ██     ██      ██ ██   ██ ██   ██ ██  ██████ ";

            // Writes the ASCII text "Super Mario"
            Console.Write(text1);
            Console.WriteLine("");

            // The color of the text "This song is 30 seconds long"
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This song is 30 seconds long");

            // The music
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            Console.WriteLine("Song has ended, press Enter to exit");
            Console.ReadKey();
        }


        public static void JingleBells()
        {
            var C4 = 261;
            var C5 = 523;
            var D4 = 293;
            var D5 = 587;
            var E4 = 329;
            var E5 = 659;
            var F5 = 698;
            var G5 = 784;

            Console.Beep(E5, 250);
            Console.Beep(E5, 250);
            Console.Beep(E5, 250);

            Thread.Sleep(350);

            Console.Beep(E5, 250);
            Console.Beep(E5, 250);
            Console.Beep(E5, 250);

            Thread.Sleep(350);

            Console.Beep(E5, 250);
            Console.Beep(G5, 250);
            Console.Beep(C5, 250);
            Console.Beep(D5, 250);
            Console.Beep(E5, 250);

            Console.Beep(C4, 250);
            Console.Beep(D4, 250);
            Console.Beep(E4, 250);

            Console.Beep(F5, 250);
            Console.Beep(F5, 250);
            Console.Beep(F5, 250);

            Thread.Sleep(350);

            Console.Beep(F5, 250);
            Console.Beep(E5, 250);
            Console.Beep(E5, 250);

            Thread.Sleep(350);

            Console.Beep(E5, 250);
            Console.Beep(D5, 250);
            Console.Beep(D5, 250);
            Console.Beep(E5, 250);
            Console.Beep(D5, 250);

            Thread.Sleep(350);
        }
    }
}
