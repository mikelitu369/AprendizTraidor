using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace System.Collections.Generic
{
    public static class DisctionaryExtraFuctions
    {
        public static K ElementAt<T, K>(this Dictionary<T, K> dic, int index)
        {
            List<T> l = dic.Keys.ToList();

            return dic[l[index]];
        }
    }
}