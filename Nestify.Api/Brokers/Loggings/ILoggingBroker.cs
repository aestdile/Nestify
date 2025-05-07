//==================================================
// Copyright(c) Coalition of Good-Hearted-Engineers
// Free To Use To Find Comfort and Peace
//==================================================



using System;

namespace Nestify.Api.Brokers.Loggings.ILoggingBroker
{
    public interface ILoggingBroker
    {
        void LogError(Exception exception);
        void LogCritical(Exception exception);
    }
}
