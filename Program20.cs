using System;
using System.Collections.Generic;
using System.Threading;

class SleepingBarber
{
    private static readonly int waitingRoomSize = 3; 
    private static Queue<int> waitingRoom = new Queue<int>();
    private static object lockObject = new object();
    private static AutoResetEvent barberWakeUp = new AutoResetEvent(false);
    private static bool barberSleeping = true;

    static void Main()
    {
        Thread barberThread = new Thread(BarberWork);
        barberThread.Start();

        int clientId = 1;
        Random rand = new Random();

        while (true)
        {
            Thread.Sleep(rand.Next(500, 1500)); 
            int id = clientId++;
            Thread clientThread = new Thread(() => ClientArrives(id));
            clientThread.Start();
        }
    }

    static void BarberWork()
    {
        while (true)
        {
            int clientId = -1;

            lock (lockObject)
            {
                if (waitingRoom.Count == 0)
                {
                    Console.WriteLine("Перукар засинає...");
                    barberSleeping = true;
                }
            }

            if (barberSleeping)
            {
                barberWakeUp.WaitOne(); 
            }

            lock (lockObject)
            {
                if (waitingRoom.Count > 0)
                {
                    clientId = waitingRoom.Dequeue();
                    Console.WriteLine($"Перукар починає стригти клієнта {clientId}.");
                }
            }

            if (clientId != -1)
            {
                Thread.Sleep(2000); 
                Console.WriteLine($"Перукар завершив стрижку клієнта {clientId}.");
            }
        }
    }

    static void ClientArrives(int id)
    {
        lock (lockObject)
        {
            if (waitingRoom.Count < waitingRoomSize)
            {
                waitingRoom.Enqueue(id);
                Console.WriteLine($"Клієнт {id} зайшов і чекає у приймальні ({waitingRoom.Count}/{waitingRoomSize}).");

                if (barberSleeping)
                {
                    Console.WriteLine($"Клієнт {id} розбудив перукаря.");
                    barberSleeping = false;
                    barberWakeUp.Set(); 
                }
            }
            else
            {
                Console.WriteLine($"Клієнт {id} не знайшов місця в приймальні і пішов геть.");
            }
        }
    }
}

