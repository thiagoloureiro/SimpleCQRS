﻿using System;
using SimpleCQRS.Contracts;
using SimpleCQRS.Loggers;
using SimpleCQRS.Serializers;

namespace SimpleCQRS.Host.Configuration
{
    public interface IHostConfiguration
    {
        IHostConfiguration ConnectTo(
            string hostName = "rabbitmq",
            int port = 5672,
            string virtualHost = "/",
            string username = "guest",
            string password = "guest");

        IHostConfiguration SetService(string serviceName);

        IHostConfiguration AddOperation<TRequest, TResponse>(string operationName, Action<Envelope<TRequest>, IHostOperation<TRequest, TResponse>> handler);

        IHostConfiguration Using(ISerializer serializer);

        IHostConfiguration Using(ILogger logger);
    }
}
