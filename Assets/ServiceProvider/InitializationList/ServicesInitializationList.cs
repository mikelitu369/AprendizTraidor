using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace MKCL.Services.Provider
{
    [CreateAssetMenu(fileName = "ServiceInitializationList", menuName = "ServiceProvider/New InitList")]
    public class ServicesInitializationList : ScriptableObject
    {
        [SerializeField] private List<IService> servicios;

        public List<IService> GetServices()
        {
            List<IService> aux = new List<IService>();

            aux = servicios.OrderBy(Service => Service.priority).ToList();

            return aux;
        }
    }
}
