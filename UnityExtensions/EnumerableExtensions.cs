using System;
using System.Collections.Generic;
using System.Linq;

namespace kosars.UnityExtensions
{
	public static class EnumerableExtensions
	{
		public static void Foreach<T>(this IEnumerable<T> enumerable, Action<T> action) {
			foreach(T item in enumerable)
				action(item);
		}

		public static T RandomElement<T>(this IEnumerable<T> enumerable) {
			return enumerable.ElementAt(UnityEngine.Random.Range(0, enumerable.Count()));
		}

		public static T RandomElement<T>(this List<T> enumerable) {
			return enumerable.ElementAt(UnityEngine.Random.Range(0, enumerable.Count));
		}

		public static T RandomElement<T>(this IEnumerable<T> enumerable, System.Random random) {
			return enumerable.ElementAt(random.Next(0, enumerable.Count()));
		}
	}
}