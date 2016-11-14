using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;


namespace LatestCosmosKernel
{
    public class Kernel : Sys.Kernel
    {
        public static LinkedList<File> fileDir;
        public static LinkedList<Variable> variables;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
            Console.WriteLine("Welcome to My OS");
            Console.WriteLine("Please type help to see a list of available Commands");
            fileDir = new LinkedList<File>();
            variables = new LinkedList<Variable>();
        }

        protected override void Run()
        {
            Console.Write("Command: ");
            var input = Console.ReadLine();
            Decider decide = new Decider(input);

        }
    }
}
