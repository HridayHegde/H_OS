using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace H_OS
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }
        
        protected override void Run()
        {
            Console.Write(">>");
            var input = Console.ReadLine();
            switch (input)
            {
                case "Intro":Console.WriteLine("Welcome To H_OS\nMade By Hriday Hegde");
                    break;

            }
        }
    }
}
