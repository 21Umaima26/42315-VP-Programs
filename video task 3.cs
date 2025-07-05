using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        
            // const field
            public const int ConstValue = 10;

            // readonly field
            public readonly int ReadOnlyValue;

            // static readonly field
            public static readonly string StaticReadOnly = DateTime.Now.ToString();

            public Example(int value)
            {
                ReadOnlyValue = value; // OK: Can assign in constructor
            }

            static void Main()
            {
                Console.WriteLine("Const Value: " + ConstValue);
                Console.WriteLine("Static ReadOnly Value: " + StaticReadOnly);

                Example obj1 = new Example(25);
                Example obj2 = new Example(50);

                Console.WriteLine("obj1.ReadOnlyValue: " + obj1.ReadOnlyValue);
                Console.WriteLine("obj2.ReadOnlyValue: " + obj2.ReadOnlyValue);

                
            }
        }

    }


