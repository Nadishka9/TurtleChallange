using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace TurtleChallange
{
    public class Command
    {
        public Navigator Navigation;
        public Table Table = new Table(5, 5);
        public bool Placed;
        public string Message = string.Empty;
        public string ErrorInputs = "Input file error.";

        public string Start(string[] commands)
        {
            Navigation = new Navigator(Table);
            foreach (string command in commands)
            {
                if (Placed)
                {
                    ProcessCommand(command);
                }
                else if (Regex.IsMatch(command, "[PLACE]"))
                {
                    Placed = true;
                    ProcessCommand(command);
                }
                if (Message == ErrorInputs)
                {
                    break;
                }
                if (Message.Length > 1)
                {
                    Console.WriteLine(Message);
                    Message = "";
                }
            }
            return Message;
        }
        public void ProcessCommand(string command)
        {
            if (Regex.IsMatch(command, "^PLACE"))
            {
                string[] coordinates = command.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                if (coordinates.Length == 4)
                {
                    int east;
                    int north;
                    bool eastTest = Int32.TryParse(coordinates[1], out east);
                    bool northTest = Int32.TryParse(coordinates[2], out north);
                    if (eastTest && northTest)
                    {
                        Navigation.Place(east, north, coordinates[3]);
                    }
                }
                if (Navigation.Turtle == null)
                {
                    Message = ErrorInputs;
                }
            }
            else if (Regex.IsMatch(command, "^MOVE") || Regex.IsMatch(command, "^RIGHT") || Regex.IsMatch(command, "^LEFT"))
            {
                Navigation.TurtleMoves(command.ToLower());
            }
            else if (Regex.IsMatch(command, "^REPORT"))
            {
                Message = Navigation.Report();
            }
            else
            {
                Message = ErrorInputs;
            }
        }
    }
}

    
