using System;
using System.Threading;

namespace ExamineThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxWorkerThread, maxIOAsyncThread;
            ThreadPool.GetMaxThreads(out maxWorkerThread, out maxIOAsyncThread);
            Console.WriteLine($"This computer Processor is {Environment.ProcessorCount}\n");
            Console.WriteLine($"Examine Thread pool...\n\n" +
                $"Max worker Thread: {maxWorkerThread}\n" +
                $"Max async I/O Thread: {maxIOAsyncThread}");
        }
    }
}
