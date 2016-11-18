using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace LatestCosmosKernel
{
    class Commands
    {
        internal static void echo(string[] array)
        {
            var x = 1;
            Console.Write("Text Echoes: ");
            while (array[x] != null)
            {
                Console.Write(findExistanceOfTheVariable(array[x]) + " ");
                x++;
            }
            Console.WriteLine();
        }

        internal static void create(string fieleNameAndExt)
        {
            Char[] inputC = fieleNameAndExt.ToCharArray();
            String name = "", ext = "";
            Boolean e = false;
            for (int i = 0; i < inputC.Length; i++)
            {
                if (inputC[i] == '.')
                    e = true;
                if (e == false)
                    name += inputC[i];
                if (e)
                    ext += inputC[i];
            }
            File file = new File(name, ext);
            String input = "";
            Int32 count = 1;
            while (input != "save")
            {
                Console.Write("Line"+count + ") ");
                input = Console.ReadLine();
                if (input != "save")
                {
                    file.setData(input);
                    count++;
                }
            }
            Console.WriteLine("*** File Saved ***");
            Kernel.fileDir.AddLast(file);
        }

        internal static void div(string[] array)
        {
            Boolean varIsInTheList = false;
            int a = find(array[1]);
            int b = find(array[2]);
            String c = array[3];
            int d = 0;
            LinkedListNode<Variable> temp = Kernel.variables.First;
            while (temp != null)
            {
                if (temp.Value.getName() == c)
                {
                    d = a / b;
                    temp.Value.updateValue(d);
                    varIsInTheList = true;
                }
                temp = temp.Next;
            }
            if (varIsInTheList == false)
            {
                d = a / b;
                Variable nv = new Variable(c, d);
                Kernel.variables.AddLast(nv);
            }
            //int a = find(array[1]);
            //int b = find(array[2]);
            //var c = array[3];
            //int d;
            //d = a / b;
            //Variable nv = new Variable(c, d);
            //Kernel.variables.AddLast(nv);
        }

        internal static void help()
        {
            Console.Write("*****************The available commands are the following*****************\n");
            Console.WriteLine("\ncreate: create a file and write into it. create <Filename>.<Extension>\n" +
                                "dir: shows a list of filename, ext, date created, file size for all files\n" +
                                    "set: set a variable to a value\n" +
                                        "echo: echo your text or variable value\n" +
                                            "add: add two values or variables\n" +
                                                "sub: subtract two values or variables\n" +
                                                    "mul: multiply add two values or variables\n" +
                                                        "div: divide add two values or variables\n");
        }

        internal static void mul(string[] array)
        {
            Boolean varIsInTheList = false;
            int a = find(array[1]);
            int b = find(array[2]);
            String c = array[3];
            int d = 0;
            LinkedListNode<Variable> temp = Kernel.variables.First;
            while (temp != null)
            {
                if (temp.Value.getName() == c)
                {
                    d = a * b;
                    temp.Value.updateValue(d);
                    varIsInTheList = true;
                }
                temp = temp.Next;
            }
            if (varIsInTheList == false)
            {
                d = a * b;
                Variable nv = new Variable(c, d);
                Kernel.variables.AddLast(nv);
            }
        }

        internal static void sub(string[] array)
        {
            Boolean varIsInTheList = false;
            int a = find(array[1]);
            int b = find(array[2]);
            String c = array[3];
            int d = 0;
            LinkedListNode<Variable> temp = Kernel.variables.First;
            while (temp != null)
            {
                if (temp.Value.getName() == c)
                {
                    d = a - b;
                    temp.Value.updateValue(d);
                    varIsInTheList = true;
                }
                temp = temp.Next;
            }
            if (varIsInTheList == false)
            {
                d = a - b;
                Variable nv = new Variable(c, d);
                Kernel.variables.AddLast(nv);
            }
        }

        internal static void set(string[] array)
        {
            String variable = array[1];
            int value = Int32.Parse(array[2]);
            LinkedListNode<Variable> temp = Kernel.variables.First;
            if (temp == null)
            {
                Variable vr = new Variable(variable, value);
                Kernel.variables.AddLast(vr);
            }
            while (temp != null)
            {
                if (temp.Value.getName() == variable)
                {
                    temp.Value.updateValue(value);
                    break;
                }
                else
                {
                    Variable vr = new Variable(variable, value);
                    Kernel.variables.AddLast(vr);
                }
                temp = temp.Next;
            }
        }

        internal static void add(string[] array)
        {
            Boolean varIsInTheList = false;
            int a = find(array[1]);
            int b = find(array[2]);
            String c = array[3];
            int d = 0;
            LinkedListNode<Variable> temp = Kernel.variables.First;
            while (temp != null)
            {
                if (temp.Value.getName() == c)
                {
                    d = a + b;
                    temp.Value.updateValue(d);
                    varIsInTheList = true;
                }
                temp = temp.Next;
            }
            if (varIsInTheList == false)
            {
                d = a + b;
                Variable nv = new Variable(c, d);
                Kernel.variables.AddLast(nv);
            }
        
        }

        internal static void run(string[] array)
        {
            
            int unmberOfTimesLoopingTheBatchFile = find(array[1]);
            Char[] inputC = array[2].ToCharArray();
            String name = "", ext = "";
            Boolean e = false;
            for (int i = 0; i < inputC.Length; i++)
            {
                if (inputC[i] == '.')
                    e = true;
                if (e == false)
                    name += inputC[i];
                if (e)
                    ext += inputC[i];
            }
            LinkedListNode<File> temp = Kernel.fileDir.First;
            while (temp != null)
            {
                if (temp.Value.getExtension() == ".bat")
                {
                    if (temp.Value.getName() == name) {
                        // this will iterate on each line that was put into the arrayList 
                        ArrayList w = new ArrayList();
                        w = temp.Value.getData();

                        for (int i = 0; i < unmberOfTimesLoopingTheBatchFile; i++)
                        {
                            for (int j = 0; j < w.Count; j++)
                            {
                                Decider d = new Decider((w[j]).ToString());
                            }
                        }
                    }
                   
                }
                temp = temp.Next;
            }
        }

        internal static void dir()
        {
            Console.WriteLine("Filename\tExtension\tDate\tSize");
            Console.WriteLine("---------------------------------------");
            LinkedListNode<File> temp = Kernel.fileDir.First;
            while (temp != null)
            {
                Console.WriteLine(temp.Value.getName() + "\t" + temp.Value.getExtension() + "\t\t" + temp.Value.getDate() + "\t" + temp.Value.getSize() + " b");
                temp = temp.Next;
            }
            Console.WriteLine("Total Files: " + Kernel.fileDir.Count);
        }

        internal static int find(String key)
        {
            int a;
            LinkedListNode<Variable> temp = Kernel.variables.First;
            while (temp != null)
            {
                if (temp.Value.getName() == key)
                {
                    a = temp.Value.getValue();
                    return a;
                }
                temp = temp.Next;
            }
            return Int32.Parse(key);
        }

        internal static Object findExistanceOfTheVariable(String key)
        {
            int a;
            LinkedListNode<Variable> temp = Kernel.variables.First;
            while (temp != null)
            {
                if (temp.Value.getName() == key)
                {
                    a = temp.Value.getValue();
                    return a;
                }
                temp = temp.Next;
            }
            return key;
        }
    }
}
