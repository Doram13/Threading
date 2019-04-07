using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingleInstance
{
    class Program
    {
        public const string MutexName = "RUNMEONLYONCE";

        static void Main(string[] args)
        {
            while (true)
            { 
                Mutex MyMutex = null;
                try
                {
                    MyMutex = Mutex.OpenExisting(MutexName);
                    MyMutex.Close();
                }
                catch (WaitHandleCannotBeOpenedException)
                {

                    MyMutex = Mutex.OpenExisting(MutexName);
                }
            }
        }
    }
}
