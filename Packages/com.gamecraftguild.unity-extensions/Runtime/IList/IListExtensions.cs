using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

namespace GameCraftGuild.UnityExtensions.IList {

    /// <summary>
    /// Extensions for IList
    /// </summary>
    public static class IListExtensions {

        /// <summary>
        /// Randomly select an object from <paramref name="list" />.
        /// </summary>
        /// <param name="list">List of objects to choose from.</param>
        /// <typeparam name="T">Type of object in <paramref name="list" />.</typeparam>
        /// <returns>Selected object from <paramref name="list" /> or default(<typeparamref name="T" />) if <paramref name="list" /> is null or empty.</returns>
        public static T GetRandomFromList<T> (this IList<T> list) {
            if (list == null || list.Count == 0) return default(T);
            if (list.Count == 1) return list[0];

            return list[Random.Range(0, list.Count)];
        }

        /// <summary>
        /// Randomly select an object from <paramref name="list" /> using provided weights for each object. An object with a nonpositive weight (weight &lt;= 0) will not be selected.
        /// </summary>
        /// <remarks>
        /// The second type for the KeyValuePair should be changed from "int" to "INumerics" once Unity supports .NET 7 and generic math.
        /// </remarks>
        /// <param name="list">List of KeyValuePairs where the Key is the object and the Value is the object's weight.</param>
        /// <typeparam name="T">Type of objects in <paramref name="list" />.</typeparam>
        /// <returns>Selected object from <paramref name="list" /> or default(<typeparamref name="T" />) if <paramref name="list" /> is null, empty, or all objects have nonpositive weight (weight &lt;= 0).</returns>
        public static T GetRandomFromWeightedList<T> (this IList<KeyValuePair<T, int>> list) {
            if (list == null || list.Count == 0) return default(T);
            if (list.Count == 1) return (list[0].Value > 0 ? list[0].Key : default(T));

            int totalWeight = 0;
            for (int index = 0; index < list.Count; index++) {
                totalWeight += list[index].Value;
            }

            int resultValue = Random.Range(0, totalWeight);
            int resultIndex = 0;

            while (resultIndex < list.Count && resultValue >= list[resultIndex].Value) {
                resultValue -= list[resultIndex].Value;
                resultIndex++;
            }

            if (resultIndex >= list.Count) return default(T);
            return list[resultIndex].Key;
        }
    }
}
