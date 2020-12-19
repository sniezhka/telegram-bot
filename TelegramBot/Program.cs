using PowerArgs;
using System;
using TelegramBot.Models;
using TelegramBot.Models.Subscribers;

namespace TelegramBot
{
    public class Program
    {
        public static void Main(string[] args)
        {          
            try
            {
                var parsed = PowerArgs.Args.Parse<Args>(args);
                (new Program()).bootstrap(parsed.Token);
            }
            catch (ArgException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ArgUsage.GenerateUsageFromTemplate<Args>());
            }
        }

        public void bootstrap(string token)
        {
            Bot bot = new Bot(token);

            bot.StartReceiving();

            Console.ReadKey();
        }
    }
}
