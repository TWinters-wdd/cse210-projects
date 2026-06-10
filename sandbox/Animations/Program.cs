class Program
{
    public static void Main(string[] args)
    {
        
        // int sleepTime = 250;

        Console.Clear();
        Console.CursorVisible = false;
        // for (int i = 0; i < 20; i++)
        // {
        //     Console.Write("+");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }
        // Console.CursorVisible = true;


        // string animationString = "-\\|/";
        // DateTime now = DateTime.Now;
        // DateTime endTime = now.AddSeconds(10);

        // // for (int i = 0; i < 20; i++)
        // int index = 0;
        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        int count = 15;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(count);

        while (count >= 0)
        {
            Console.Write($"{count--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.CursorVisible = true;

    }
}