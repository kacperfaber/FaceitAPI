using System;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public static class Extensions
    {
        public static int Count<T>(this Paging<T> paging)
        {
            return paging.Items.Length;
        }

        public static void ForEach<T>(this Paging<T> paging, Action<T> action)
        {
            foreach (T t in paging.Items) action(t);
        }

        public static void For<T>(this Paging<T> paging, Action<int> action)
        {
            for (int i = (int) paging.Start; i <= paging.End; i++) action(i);
        }
    }
}