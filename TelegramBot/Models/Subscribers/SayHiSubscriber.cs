﻿using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramBot.Models.Subscribers
{
    public class SayHiSubscriber
    {
        public static async void Handle(object sender, MessageEventArgs e)
        {
            ITelegramBotClient bot = sender as TelegramBotClient;

            if (e.Message.Text != null && e.Message.Text == "Hi")
            {
                await bot.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "Hi!"
                );
            }
        }
    }
}
