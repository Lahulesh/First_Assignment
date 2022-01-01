using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_1
{
   
    class Program
    {
        string[] data = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
        //First
        void readinput()
        {
            string fileName = @"C:\Users\lahulesh.chourasiya\Desktop\data.txt";
            FileStream stream = null;
            Console.WriteLine("How Many Names You Enter(15 is Maximum)");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size <= 15)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine($"Enter Only {size} Random Name.");
                string[] grade = new string[size];
                for (int i = 0; i < grade.Length; i++)
                {
                    grade[i] = Console.ReadLine();
                }
                    stream = new FileStream(fileName, FileMode.OpenOrCreate);
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        for (int a = 0; a < grade.Length; a++)
                        {
                            writer.WriteLine(grade[a]);
                        }
                    }
                Console.WriteLine("########Your Enter#############");
                    string readtext = File.ReadAllText(fileName);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Input...");
            }
            readers();
        }
        void readers()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        //Second
        void reverse()
        {
            string[] data = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            Console.WriteLine("**********************Reverse Value Start*******************************");
            for (int a = data.Length - 1; a > -1; a--)
            {
                Console.WriteLine(data[a]);
            }
            Console.WriteLine("**********************Reverse Value End*******************************");
        }
        //Third
        void last3value()
        {
            string[] data = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            Console.WriteLine("*****************************Last 3 Values Start******************************");
            for (int count = 1; count <= 3; count++)
            {
                Console.WriteLine(data[data.Length - count]);
            }
            Console.WriteLine("*****************************Last 3 Values End******************************");
        }
        //Fourth
        void only2value()
        {
            string[] data = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            Console.WriteLine("**********************Only Second Records Start*******************************");
            Console.WriteLine(data[1]);
            Console.WriteLine("**********************Only Second Records End*******************************");
        }
        //Fifth
        void selection(string[] data)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            Console.WriteLine("****************************Starting Values******************************");
            foreach (String str in lines)
                Console.WriteLine(str + ",");
            Console.WriteLine();
            
            for (int j = 0; j < lines.Length - 1; j++)
            {
                int min = j;
                for (int k = j + 1; k < lines.Length; k++)
                {
                    if (lines[k].CompareTo(lines[min]) < 0) min = k;

                    String temp = lines[j];
                    lines[j] = lines[min];
                    lines[min] = temp;
                }
            }
            Console.WriteLine("**********************After Ascending order*******************************");
            foreach (String str in lines)
            {
                Console.WriteLine(str + ",");
            }
            Console.WriteLine();
        }
        //Sixth
        void top2value()
        {
            string[] data = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            Console.WriteLine("********************Print First 2 Values Start*******************************");
            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            Console.WriteLine("********************Print First 2 Values End*******************************");
        }
        //Seventh
        void Isvowel(string[] str)
        {
            string[] data = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            Console.WriteLine("*********************Your vowels Values Start****************************");
            foreach (var v in data)
            {
                char[] letters = v.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == 'a' || letters[i] == 'e' || letters[i] == 'i' || letters[i] == 'o' || letters[i] == 'u')
                    {
                        Console.WriteLine(v);
                        break;
                    }
                }
            }
            Console.WriteLine("*********************Your vowels Values End****************************");
        }
        //Eight
        void duplicate()
        {
            string[] data = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            Console.WriteLine("********************Duplicate Value Start*******************************");
            int v = 1;
            for (int a = 0; a < data.Length; a++)
            {
                for (int j = a + 1; j < data.Length; j++)
                {
                    if (data[a] == data[j])
                    {
                        if( v ==1 && data[j]!="")
                        {
                            Console.WriteLine(data[a] + " ");
                        }
                        data[j] = "";
                        v++;
                    }
                }
                v = 1;
            }
            Console.WriteLine("********************Duplicate Value End*******************************");
        }
        //Ninth
        void exit()
        {
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            string[] data = System.IO.File.ReadAllLines(@"C:\Users\lahulesh.chourasiya\Desktop\data.txt");
            Program pobj = new Program();
            int selection;
            string input;
            string[] names = new string[10];
            int alength = names.Length;
            Boolean exit = false;
            Console.WriteLine("Press 1 to print all the names");
            Console.WriteLine("Press 2 to print all the names in reverse");
            Console.WriteLine("Press 3 to print last 3  names");
            Console.WriteLine("Press 4 to print 2 record from the list");
            Console.WriteLine("Press 5 to print sort in ascending order");
            Console.WriteLine("Press 6 to print first 2 names");
            Console.WriteLine("Press 7 to print all the names that contains vowels");
            Console.WriteLine("Press 8 to print duplicate values");
            Console.WriteLine("Press 9 to print to exit");
            do
            {
                Console.WriteLine("Please Select the Appropriate Number:");
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        pobj.readinput();
                        break;
                    case 2:
                        pobj.reverse();
                        break;
                    case 3:
                        pobj.last3value();
                        break;
                    case 4:
                        pobj.only2value();
                        break;
                    case 5:
                        pobj.selection(pobj.data);
                        break;
                    case 6:
                        pobj.top2value();
                        break;
                    case 7:
                        pobj.Isvowel(data);
                        break;
                    case 8:
                        pobj.duplicate();
                        break;
                    case 9:
                        pobj.exit();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Number");
                        break;
                }
            } while (true);
            Console.ReadKey();
        }
        
    }
}
