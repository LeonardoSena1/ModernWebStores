using System;

namespace ModernWebStores.SharedKernel.Events.Concrats
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }   
}
