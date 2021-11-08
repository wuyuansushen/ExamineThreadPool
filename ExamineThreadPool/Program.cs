using System;
using System.Threading;

namespace ExamineThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxWorkerThread, maxIOAsyncThread;
            int minWorkerThread, minIOAsyncThread;
            ThreadPool.GetMaxThreads(out maxWorkerThread, out maxIOAsyncThread);
            ThreadPool.GetMinThreads(out minWorkerThread, out minIOAsyncThread);
            Console.WriteLine($"This computer Processor is {Environment.ProcessorCount}\n");
            Console.WriteLine($"Examine Thread pool...\n");
            Console.WriteLine(
                $"Min worker Thread: {minWorkerThread}\n" +
                $"Max worker Thread: {maxWorkerThread}\n");
            Console.WriteLine(
                $"Min async I/O Thread: {minIOAsyncThread}\n"+
                $"Max async I/O Thread: {maxIOAsyncThread}\n");
        }
    }
}
