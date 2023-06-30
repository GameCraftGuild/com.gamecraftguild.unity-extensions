using System.Collections.Generic;

using Random = UnityEngine.Random;

namespace GameCraftGuild.UnityExtensions.IList {

    /// <summary>
    /// Extensions for IList
    /// </summary>
    public static class IListExtensions {

        /// <summary>
        /// Randomly select an item from <paramref name="list" />.
        /// </summary>
        /// <param name="list">List of items to choose from.</param>
        /// <typeparam name="T">Type of item in <paramref name="list" />.</typeparam>
        /// <returns>Selected item from <paramref name="list" /> or default(<typeparamref name="T" />) if <paramref name="list" /> is null or empty.</returns>
        public static T GetRandomItem<T> (this IList<T> list) {
            if (list == null || list.Count == 0) return default(T);
            if (list.Count == 1) return list[0];

            return list[Random.Range(0, list.Count)];
        }

        /// <summary>
        /// Randomly select an item from <paramref name="list" /> using the weights in <paramref name="weights" /> given for each object. An object with a nonpositive weight (weight &lt;= 0) will not be selected.
        /// </summary>
        /// <remarks>
        /// The type for <paramref name="weights" /> should be changed from "int" to "INumerics" once Unity supports .NET 7 and generic math.
        /// </remarks>
        /// <param name="list">List of items of type :<typeparamref name="T" />.</param>
        /// <param name="weights">Weights for each object.</param>
        /// <typeparam name="T">Type of items in <paramref name="list" />.</typeparam>
        /// <returns>Selected item from <paramref name="list" /> or default(<typeparamref name="T" />) if <paramref name="list" /> or <paramref name="weights" /> is null or empty, the list lengths do not match, or all items have nonpositive weight (weight &lt;= 0).</returns>
        public static T GetRandomItemWeighted<T> (this IList<T> list, IList<int> weights) {
            if (list == null || weights == null || list.Count == 0 || weights.Count == 0 || list.Count != weights.Count) return default(T);
            if (list.Count == 1) return (weights[0] > 0 ? list[0] : default(T));

            int totalWeight = 0;
            for (int index = 0; index < weights.Count; index++) {
                totalWeight += weights[index];
            }

            int resultValue = Random.Range(0, totalWeight);
            int resultIndex = 0;

            while (resultIndex < list.Count && resultValue >= weights[resultIndex]) {
                resultValue -= weights[resultIndex];
                resultIndex++;
            }

            if (resultIndex >= list.Count) return default(T);
            return list[resultIndex];
        }
    }
}
