using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            // Global variable (class-level)
            int globalCounter = 0;

            public void IncreaseCounter()
            {
                // Local variable
                int localCounter = 0;

                globalCounter++;
                localCounter++;

                Console.WriteLine("Global Counter: " + globalCounter);
                Console.WriteLine("Local Counter: " + localCounter);
            }

            static void Main()
            {
                VariableScope obj = new VariableScope();

                Console.WriteLine("First Call:");
                obj.IncreaseCounter();

                Console.WriteLine("\nSecond Call:");
                obj.IncreaseCounter();
            }
        }

    }


