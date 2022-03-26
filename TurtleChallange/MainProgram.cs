using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TurtleChallange
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please make the command text file");
                return;
            }
            if (File.Exists(args[0]) && (Path.GetExtension(args[0]) == ".txt"))
            {
                string[] commands = File.ReadAllLines(args[0]);
                MainProgram main = new MainProgram();
                Console.WriteLine(main.Commander(commands));
            }
            else
            {
                Console.WriteLine("Invalid text file.");
                Console.Write(@"Please use the following commands:
PLACE X,Y,DIRECTION
MOVE
RIGHT
LEFT
REPORT
-------------
.");
            }
        }

        public string Commander(string[] commands)
        {
            string message = "";
            Command obj = new Command();
            if (obj != null)
            {
                message = obj.Start(commands);
            }
            return message;
        }
    }
}