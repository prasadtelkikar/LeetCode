using System;
using System.Collections.Generic;

namespace Easy_Problems
{
    public class GoalParser
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string parsedCommand = Interpret(command);
            Console.WriteLine(parsedCommand);
        }

        private static string Interpret(string command)
        {
            List<char> chars = new List<char>();
            for (int i = 0; i < command.Length;)
            {
                if(command[i] == 'G')
                {
                    chars.Add(command[i]);
                    i++; //Move forward by 1
                }
                else if(command[i] == '(' && command[i+1] == ')')
                {
                    chars.Add('o');
                    i += 2; //Move forward by 2
                }
                else
                {
                    chars.AddRange(new [] { 'a', 'l' });
                    i+=4;  //Move forward by 4
                }
            }
            return new string(chars.ToArray());
        }

        //Cheated: Cleaver solution
        private static string InterpretStringInbuildFunc(string command)
        {
            var result = command.Replace("()", "o").Replace("(al)", "al");
            return result;
        }
    }
}
