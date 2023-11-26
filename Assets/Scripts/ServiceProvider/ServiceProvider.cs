using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace MKCL.Services
{
    public abstract class ServiceProvider<T> : MonoBehaviour, IServiceProvider where T : IServiceProvider
    {
        public static ServiceProvider<T> Instance;

        private bool servicesInitialized = false;

        private bool servicesRegistered = false;

        private event Action OnServicesInitialized;
        public event Action ServicesInitialized {
            add {
                OnServicesInitialized += value;
                if (servicesInitialized) OnServicesInitialized.Invoke();
            }
            remove {
                OnServicesInitialized -= value;
            }
        }

        private event Action OnServicesRegistered;
        public event Action ServicesRegistered {
            add {
                OnServicesRegistered += value;
                if (servicesRegistered) OnServicesRegistered.Invoke();
            }
            remove {
                OnServicesRegistered -= value;
            }
        }

        private Dictionary<Type, IService> services = new Dictionary<Type, IService>();

        protected ServicesInitializationList config;

        protected void Awake()
        {
            if (!Instance) Instance = this;
            else Destroy(this.gameObject);
            DoOnAwake();
        }

        protected virtual void DoOnAwake() { }
        protected virtual void DoBeforeRegister() { }
        protected virtual void DoBeforeInit() { }
        protected virtual void DoAfterInit() { }

        protected async void Start()
        {
            DoBeforeRegister();

            foreach (IService service in config.GetServices())
            {
                GameObject serviceObject = Instantiate(((MonoBehaviour)service).gameObject, this.transform);
                serviceObject.GetComponent<IService>().Register(this);
            }

            servicesRegistered = true;
            OnServicesRegistered?.Invoke();

            DoBeforeInit();

            foreach (IService service in services.Values)
            {
                await service.InitializeService();
            }

            DoAfterInit();

            servicesInitialized = true;
            OnServicesInitialized?.Invoke();
        }

        public TService Get<TService>() where TService : IService
        {
            IService service;

            if (services.TryGetValue(typeof(TService), out service))
            {
                return (TService)service;
            }

            Debug.LogError("Service not found: " + typeof(T));
            throw new System.Exception();
        }

        public void Set<TService>(TService service) where TService : IService
        {
            services[typeof(TService)] = service;
        }

        protected void OnDestroy()
        {
            for (int i = services.Values.Count - 1; i >= 0; --i)
            {
                //Crear una funcion extra para dicionarios
                //Debug.Log("Going to finalize service: " + services.ElementAt(i).Value);
                services.ElementAt(i).FinalizeService();
            }
            

            //crear un extrafucions del dicionario 
        }

    }
}
