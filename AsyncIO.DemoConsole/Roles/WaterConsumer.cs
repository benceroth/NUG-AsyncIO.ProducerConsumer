﻿using AsyncIO.DemoConsole.Models;
using AsyncIO.ProducerConsumer.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncIO.DemoConsole.Roles
{
    class WaterConsumer : IConsumer
    {
        bool IConsumer.CanConsume(object item)
        {
            return item is Water;
        }

        void IConsumer.Consume(object item)
        {
        }
    }
}