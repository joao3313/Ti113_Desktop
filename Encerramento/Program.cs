namespace Encerramento
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                DateTime agora = DateTime.Now;
                Console.Clear();
                Console.WriteLine("Relógio Atualizado: " + agora.ToString("HH:mm:ss"));

                if (agora.Hour == 22 && agora.Minute == 15)
                {
                    Console.WriteLine("\n*** ALARME: São 22:15! ***");
                    Console.Beep();
                    break;
                }

                Thread.Sleep(1000);
            }
        }
    }
}