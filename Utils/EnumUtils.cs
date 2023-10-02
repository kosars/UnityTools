using System;
using System.Linq;

namespace kosars.UnityExtensions
{
    public class EnumUtils<T> where T : struct, Enum
    {
        public static int Count = Enum.GetNames(typeof(T)).Length;

        public static int MaxValue = ((T[])Enum.GetValues(typeof(T))).Select(v => Convert.ToInt32(v)).Max();

        public static T Parse(string str) {
            if(Enum.TryParse(str, out T result)) {
                return result;
            }
            throw new ArgumentException("Unknown enum value: " + str);
        }

        public static T ParseOrDefault(string str, T defaultValue) {
            if(Enum.TryParse(str, out T result)) {
                return result;
            }
            return defaultValue;
        }
    }

    public static class EnumExtensions 
    {
        public static int ToInt<T>(this T soure) where T : Enum {
            return (int)(IConvertible)soure;
        }
    }
}