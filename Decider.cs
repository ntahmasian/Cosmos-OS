using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestCosmosKernel
{
    class Decider
    {
        
        public Decider(String cmdLine)
        {
            String[] array = cmdLine.Split(' ');
            var x = 0;
            
            if (array[x] == "echo")
            {
                Commands.echo(array);
            }
            else if (array[x] == "create")
            {
                x++;
                Commands.create(array[x]);
            }
            else if (array[x] == "add")
            {
                Commands.add(array);
            }
            else if (array[x] == "dir")
            {
                Commands.dir();
            }
            else if (array[x] == "sub")
            {
                Commands.sub(array);
            }
            else if (array[x] == "mul")
            {
                Commands.mul(array);
            }
            else if (array[x] == "div")
            {
                Commands.div(array);
            }
            else if (array[x] == "set")
            {
                Commands.set(array);
            }
            else if (array[x] == "help")
            {
                Commands.help();
            }
            else if (array[x] == "run")
            {
                x++;
                Commands.run(array[x]);
            }
            else
            {
                Console.WriteLine("Invalid entery, Please try again");
            }
        }

    }
}
