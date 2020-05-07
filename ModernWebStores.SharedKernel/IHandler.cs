using ModernWebStores.SharedKernel.Events.Concrats;
using System;
using System.Collections.Generic;

namespace ModernWebStores.SharedKernel
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handler(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
