
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.NetworkInformation;

namespace ConsoleApplication2
{
    public class AV
    {
        public void LocalSpeed()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                IPv4InterfaceStatistics stats = adapter.GetIPv4Statistics();
                Console.WriteLine(adapter.Description);
                Console.WriteLine("     Speed .................................: {0}",
                    adapter.Speed);
                Console.WriteLine("     Output queue length....................: {0}",
                    stats.OutputQueueLength);
            }
        }
    }
   
    
    public class Program
    {
        static void Main(string[] args)
        {
            AV bv = new AV();
            bv.LocalSpeed();



            Overlod abcc = new Overlod();
           
            Console.WriteLine(abcc.Add3("aaa", 10));
            // Hello world abc git
            //hello
            //try
            //{
            //    int aaa = 8, bbb = 0;
            //    int ccc = aaa / bbb;
            //    Console.WriteLine(ccc);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}



            //List<string> strings = new List<string>();
            //strings.Add("one");
            //strings.Add("two");
            //strings.Add("three");

            //IEnumerable<string> ieStrings = strings.Where(s => s.Length >= 2);
            //foreach (string s in ieStrings)
            //{
            //    Console.WriteLine("Processing " + s);
            //}

            //Console.ReadKey();
            //strings.Add("six");
            //Console.WriteLine("source enumerable changed but query is not invoked again");
            ////query is not invoked explicitly, ieStrings is not changes 
            //foreach (string s in ieStrings)
            //{
            //    Console.WriteLine("Processing " + s);
            //}

            int[] a = new int[5] { 2, 4, 6, 7, 8 };
            var c= new int[5];
            var b = (from i in a select i).Sum();
            //foreach(int i in b)
            Console.WriteLine(b);

            Console.WriteLine("Enter Array lenth:");
            int[] input = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Please enter 0-9 values");
            for(int n=0;n< input.Length; n++)
            {
                input[n] = int.Parse(Console.ReadLine());
            }
            string[] str = new string[input.Length];
           for(int i=0;i<input.Length;i++)
            {
                switch (input[i])
                {
                    case 0: str[i] = "Zero"; break;
                    case 1: str[i] = "One"; break;
                    case 2: str[i] = "Two"; break;
                    case 3: str[i] = "Three"; break;
                    case 4: str[i] = "Four"; break;
                    case 5: str[i] = "Five"; break;
                    case 6: str[i] = "Six"; break;
                    case 7: str[i] = "Seven"; break;
                    case 8: str[i] = "Eight"; break;
                    case 9: str[i] = "Nine"; break;
                    default: break;
                }

            }
            for (int m = 0; m < str.Length; m++)
            {
                Console.WriteLine(str[m]);
            }

            //Stack stk = new Stack();
            //stk.Push("Ajay");
            //stk.Push("Singh");

            //Console.WriteLine(stk.Pop());
            //Console.WriteLine(stk.Pop());


            //Queue qu = new Queue();
            //qu.Enqueue("Ajay");
            //qu.Enqueue("Singh");
            //Console.WriteLine(qu.Dequeue());
            //Console.WriteLine(qu.Dequeue());


            //long i, Num;
            //Console.WriteLine("enter number no");
            //Num = int.Parse(Console.ReadLine());

            //for(i=Num-1;i>0;i--)
            //{
            //    Num *= i;
            //}
            //Console.WriteLine(Num);

            //int i, max, min, sum = 0;
            //Console.WriteLine("enter lowest no");
            //min = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter highest no");
            //max = int.Parse(Console.ReadLine());
            //for (i = min + 1; i < max; i++)
            //{
            //    sum = sum + i;
            //}
            //for(i=max-1;i>min;i--)
            //{
            //    Console.WriteLine(i);
            //}
            //max -= 1;
            //while(min<max)
            //{

            //    Console.WriteLine(max);
            //    max--;
            //}
            //do
            //{
            //    Console.WriteLine(max);
            //    max--;
            //} while (min > max);


            //Console.WriteLine("sum of natural no:{0}", sum);

            //IABC abc = new ABC();
            //IABD abd = new ABC();

            //int a = 20;
            //int b = 15;
            //var result =abc.Add(a,b);

            ////var a = abc.Sub(10,4);
            //Console.WriteLine(result);
            //Console.WriteLine(abc.Str("Ajay"));
            //result = abd.Mul(a,b);
            //Console.WriteLine(result);

            Console.ReadKey();
        }
    }
   
    public class Overlod
    {
        private void Add()
        {
            Console.WriteLine("Private");
        }
        public int MUL(int aa,int bb) 
        {
            return aa * bb;
        }
        public string Add3(string aa,int bb)
        {
            Add();
            return aa+' '+bb; 
        }
    }

    public class ABC: IABC, IABD
    {
        delegate void abcdf();
        public int Add(int a, int b)
        {
           
            //var aa=this.Sub(out a,b);
            //Console.WriteLine(aa);

            return (a+b);
        }
        public string Str(string Name)
        {
            return Name+"Singh";
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }

    public interface IABC
    {
        int Add(int a,int b);
        string Str(string Name);
    }
    public interface IABD
    {
        int Sub(int a, int b);
        int Mul(int a, int b);
    }

}
