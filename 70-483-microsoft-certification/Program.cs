using System;
using System.Threading;

namespace _70_483_microsoft_certification
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(DoSomeStuff)); //Creates a new Thread and add a method to be executed on it

            ///Um thread é um thread em segundo plano ou um thread em primeiro plano. Os threads em segundo plano são idênticos aos threads em primeiro plano, exceto que os threads em segundo plano não impedem que um processo Depois que todos os threads de primeiro plano que pertencem a um processo forem encerrados, o Common Language Runtime encerrará o processo. Quaisquer threads de segundo plano restantes são interrompidos e não são concluídos.
            t.IsBackground = false; //Gets or sets the background property of the Thread

            ///A thread’s priority shows how frequently a thread gains the access to CPU resources. The by default priority of a thread is Normal.
            t.Priority = ThreadPriority.Highest; //Gets or sets the priority property of the Thread

            t.Start(); //Starts the Thread
            t.Join(); //Pauses the current Thread and waits until the t Thread terminate

            Thread.Sleep(3500); //Pauses the current Thread for 3.5 seconds (3500 milliseconds)
            Console.WriteLine("This Thread did some stuff after 3.5 seconds");

            ///Another way to add a method to a Thread is using an anonymous method defined by a lambda expression
            Thread t2 = new Thread(() =>
            {
                int sum = 0;
                for (int i = 0; i < 100000; i++)
                {
                    sum += 1;
                    Console.Write($"{sum} ");
                }
            });

            t2.Start();

            Console.ReadKey();
        }

        static void DoSomeStuff()
        {
            Thread.Sleep(3000); //Pauses the current Thread for 3 seconds (3000 milliseconds)
            Console.WriteLine("This Thread did some stuff after 3 seconds");
        }
    }
}
