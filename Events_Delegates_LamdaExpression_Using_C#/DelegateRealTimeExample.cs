using System;
using System.Threading;
namespace DelegatesRealTimeExample
{
    public delegate void WorkPerformedHandler(int hours, string workType);
    public delegate void WorkCompletedHandler(string workTyp);
    public class Worker
    {
        public void DoWork(int hours, string workType, WorkPerformedHandler del1, WorkCompletedHandler del2)
        {
            //Do Work here and notify the consumer that work has been performed
            for (int i = 0; i < hours; i++)
            {
                //Do Some Processing
                Thread.Sleep(1000);
                //Notfiy how much works have been done
                del1(i + 1, workType);
            }

            //Notfiy the consumer that work has been completed
            del2(workType);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(Worker_WorkPerformed);
            WorkCompletedHandler del2 = new WorkCompletedHandler(Worker_WorkCompleted);
            Worker worker = new Worker();
            worker.DoWork(5, "Generating Report", del1, del2);
            Console.ReadKey();
        }
        //Delegate Signature must match with the method signature
        static void Worker_WorkPerformed(int hours, string workType)
        {
            Console.WriteLine($"{hours} Hours compelted for {workType}");
        }
        static void Worker_WorkCompleted(string workType)
        {
            Console.WriteLine($"{workType} work compelted");
        }
    }
}