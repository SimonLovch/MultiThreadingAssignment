namespace MultiThreadingAssigment.Threads
{
 
    //Всё что нужно вызвать методы класса не создавая экземпляр поэтому статик 

    public static class ThreadsMethods
    {
        public static void StartThreads(int threadsCount)
        {
            for (int i = 1; i < threadsCount + 1; i++)
            {
                Thread printThread = new(PrintThreads);
                printThread.Name = $"{i}";
                printThread.Start();
            }

        }

        private static void PrintThreads()
        {
            int i = 1;
            while (!Console.KeyAvailable)
            {
                Console.WriteLine($"{{{Thread.CurrentThread.Name}}} - {{{i}}}");
                i++;
                Thread.Sleep(1000);
            }
        }
    }
}
