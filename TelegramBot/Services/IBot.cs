﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TelegramBot.Services
{
    public interface IBot
    {
        void ProcessMessage(Update update);
    }
}
