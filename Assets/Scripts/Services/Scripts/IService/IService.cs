using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MKCL.Services.Provider;
using System.Threading.Tasks;

namespace MKCL.Services
{
    public interface IService
    {
        int priority { get; set; }

        void Register(IServiceProvider serviceProvider);

        Task InitializeService();

        void FinalizeService();
    }
}
