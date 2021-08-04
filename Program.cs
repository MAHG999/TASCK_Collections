using System;
using System.Threading.Tasks;

namespace Async_Tasck_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] TASK = new Task[3];

            TASK[0] = Task.Run(Request1);
            TASK[1] = Task.Run(Request2);
            TASK[2] = Task.Run(Request3);

           
            Task.WaitAll(TASK);
            Console.WriteLine("Esperando culminación de las tareas");
        }
    
        public static void Request1()
        {
            Task.Delay(2000);
            Console.WriteLine("Solicitud Serio 1");
        }
        public static void Request2()
        {
            Task.Delay(2000);
            Console.WriteLine("Solicitud Serio 2");
        }
        public static void Request3()
        {
            Task.Delay(2000);
            Console.WriteLine("Solicitud Serio 3");
        }
    }
}
