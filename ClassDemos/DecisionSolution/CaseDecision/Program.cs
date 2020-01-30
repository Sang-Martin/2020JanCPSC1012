﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeLetter = "c";
            string percentageRange;

            //a case structure can be used when you have a 
            //single argument value compared to 
            //a series of literal values

            //the structure bwgins with switch (argument value) {...}
            //within the switch structure you have "cases"
            //a "case" represents on "if" test against the argument value 
            //the case can must end with a "break;" command
            //the "break" sends you execution to the end of the switch 
            //  structure
            //the last case in your switch is a special case called "defaulf"
            //"defaut" DOES NOT test against a literal value
            //default executes if NONE of the previous cases were executed
            //you can have multiple case statements code for a particular 
            //case coding block
            //multiple case statements for a particular case coding block are 
            //implied logical OR (||) testss
            //the case test is a relational equal (==) test
            //switch(gradeLetter)
            //{
            //    case "a":
            //    case "A":
            //        {
            //            //logic for this particular case
            //            percentageRange = "85 - 100";
            //            break;
            //        }
            //    case "b":
            //    case "B":
            //        {
            //            //logic for this particular case
            //            percentageRange = "70 - 84";
            //            break;
            //        }
            //    case "c":
            //    case "C":
            //        {
            //            //logic for this particular case
            //            percentageRange = "55 - 69";
            //            break;
            //        }
            //    case "d":
            //    case "D":
            //        {
            //            //logic for this particular case
            //            percentageRange = "40 - 54";
            //            break;
            //        }
            //    case "f":
            //    case "F":
            //        {
            //            //logic for this particular case
            //            percentageRange = "0-39";
            //            break;
            //        }
            //    default:
            //        {
            //            //the implied test on this case is "None of the about"
            //            percentageRange = "Invalid enter grade";
            //            break;
            //        }
            //}//eos

            switch (gradeLetter.ToUpper())
            {
                case "A":
                    {
                        //logic for this particular case
                        percentageRange = "85 - 100";
                        break;
                    }
                case "B":
                    {
                        //logic for this particular case
                        percentageRange = "70 - 84";
                        break;
                    }
                case "C":
                    {
                        //logic for this particular case
                        percentageRange = "55 - 69";
                        break;
                    }
                case "D":
                    {
                        //logic for this particular case
                        percentageRange = "40 - 54";
                        break;
                    }
                case "F":
                    {
                        //logic for this particular case
                        percentageRange = "0-39";
                        break;
                    }
                default:
                    {
                        //the implied test on this case is "None of the about"
                        percentageRange = "Invalid enter grade";
                        break;
                    }
            }//eos
            Console.WriteLine($"Your grade letter ({gradeLetter}) is {percentageRange}");
            Console.ReadKey();//When using debugging to spot the auto closing 
        }

    }
}