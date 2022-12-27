using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AC_Hack
{
    class Program
    {
        public static int Base = 0x004E4DBC;
        public static int Health = 0xF4;

        static void Main(string[] args)
        {
            VAMemory vam = new VAMemory("ac_client");

            int LocalPlayer = vam.ReadInt32((IntPtr)Base);
            int LocalPlayer2 = vam.ReadInt32((IntPtr)Base);

            Console.Title = "https://github.com/itssnee";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Assault Cube hack v1");
            Console.WriteLine("Enabling Godmode...");
            Thread.Sleep(500);
            Console.WriteLine("Enabled Godmode succesfully!");
            Console.ResetColor();
            while (true)
            {
                int address = LocalPlayer + Health;
                vam.WriteInt32((IntPtr)address, 9999);

                Thread.Sleep(100);


            }



        }
    }
}
