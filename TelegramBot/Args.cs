using System;
using System.Collections.Generic;
using System.Text;
using PowerArgs;

namespace TelegramBot
{
    class Args
    {       
        [ArgRequired(PromptIfMissing = true)]
        public string Token { get; set; }
    }
}
