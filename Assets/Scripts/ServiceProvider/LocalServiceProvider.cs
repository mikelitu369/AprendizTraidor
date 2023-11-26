using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MKCL.Services
{
    public class LocalServiceProvider : ServiceProvider<LocalServiceProvider>, IServiceProvider
    {
        private new void Start()
        {
            GlobalServiceProvider.Instance.ServicesInitialized += ExecuteStart;         
        }

        private void ExecuteStart()
        {
            base.Start();
            GlobalServiceProvider.Instance.ServicesInitialized -= ExecuteStart;
        }
    }
}
