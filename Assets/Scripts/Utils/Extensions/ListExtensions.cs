using MKCL.Cards;

namespace System.Collections.Generic
{
    public static class ListExtraFuctions
    {
        public static void Shuffle<T>(this List<T> list)
        {
            int count = list.Count;
            int last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = UnityEngine.Random.Range(i, count);
                var tmp = list[i];
                list[i] = list[r];
                list[r] = tmp;
            }
        }

        public static void Activate(this List<CardEffect> list)
        {
            foreach (CardEffect effect in list) effect.Activate();
        }
    }
}
