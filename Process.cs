using System;
using System.Diagnostics;

namespace ActionFunc
{
    class Program
    {

        static void Main(string[] args)
        {
            Process p1 = new Process();

            try
            {

                p1.StartInfo.FileName = "/Applications/Pages.app/Contents/MacOS/Pages";
                p1.Start();
                p1.WaitForExit();
            
            }
            catch (Exception ex)
            {
                Console.WriteLine("eror" + ex.Message);
            }
        }
    }
    

    }

