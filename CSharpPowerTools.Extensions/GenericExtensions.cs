using System;

namespace CSharpPowerTools.Extensions
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public static class GenericExtensions
    {
        public static int SafeCount<T>(this ICollection<T> items)
        {
            return items == null ? 0 : items.Count;
        }

        public static long SafeCountLong<T>(this ICollection<T> items)
        {
            return items == null ? 0L : items.LongCount();
        }

        public static int SafeCount(this ICollection items)
        {
            return items == null ? 0 : items.Count;
        }

        public static int SafeCount<T>(this IList<T> items)
        {
            return items == null ? 0 : items.Count;
        }

        public static long SafeCountLong<T>(this IList<T> items)
        {
            return items == null ? 0L : items.LongCount();
        }

        public static int SafeCount<T>(this T[] items)
        {
            return items == null ? 0 : items.Length;
        }

        public static long SafeCountLong<T>(this T[] items)
        {
            return items == null ? 0L : items.LongLength;
        }
    }
}