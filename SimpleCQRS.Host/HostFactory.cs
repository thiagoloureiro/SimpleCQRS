﻿using System;
using RabbitMQ.Client;
using SimpleCQRS.Host.Configuration;

namespace SimpleCQRS.Host
{
    public static class HostFactory
    {
        public static IHost Create(Action<IHostConfiguration> configure)
        {
            var config = new HostConfiguration();
            configure(config);

            return new CQRSHostV2(config);
        }
    }
}
