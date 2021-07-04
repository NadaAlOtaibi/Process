using System;
using System.Diagnostics;

namespace ActionFunc
{
    class Program
    {

        static void Main(string[] args)
        {
            Process[] processlist = Process.GetProcesses();
            foreach(Process theprocess in processlist)
            {
                Console.WriteLine("Process: {0} ID:{1} Number of Threads: {2}",
                    theprocess.ProcessName, theprocess.Id,theprocess.Threads.Count);

            }
        }
    }
    

    }

