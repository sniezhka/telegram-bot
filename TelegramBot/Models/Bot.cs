using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramBot.Models
{
    class Bot
    {
        private readonly ITelegramBotClient _bot;

        public Bot(string accessToken)
        {
            this._bot = new TelegramBotClient(accessToken);
        }

        public void StartReceiving()
        {
            _bot.StartReceiving();
        }

        public void StopReceiving()
        {
            _bot.StopReceiving();
        }

        public void AttachSubscriber(EventHandler<MessageEventArgs> subscriber)
        {
            _bot.OnMessage += subscriber;
        }
    }
}
