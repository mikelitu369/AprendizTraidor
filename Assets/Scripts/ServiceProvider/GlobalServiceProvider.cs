using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MKCL.Services
{
    public class GlobalServiceProvider : ServiceProvider<GlobalServiceProvider>, IServiceProvider
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
            base.Awake();
        }
    }
}