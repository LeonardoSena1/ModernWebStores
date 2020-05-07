using System;
using System.Collections.Generic;

namespace ModernWebStores.SharedKernel
{
    public interface IContainer
    {
        T GetService<T>();
        object GetService(Type serviceType);
        IEnumerable<T> Getservices<T>();
        IEnumerable<object> Getservices(Type serviceType);
    }
}
