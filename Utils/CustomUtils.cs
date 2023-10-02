using System.Collections;
using UnityEngine;

namespace kosars.UnityExtensions
{
    public static class CustomUtils
    {
        public static void Swap<T>(ref T a, ref T b) {
            var tmp = a;
            a = b;
            b = tmp;
        }
    }
}