using System;

namespace MKCL.Services
{ 

    public interface IServiceProvider
    {
        event Action ServicesInitialized;

        void Set<T>(T service) where T : IService;

        T Get<T>() where T : IService;
    }
}

