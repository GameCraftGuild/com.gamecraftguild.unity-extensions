using System.Collections.Generic;
using UnityEngine;

namespace GameCraftGuild.UnityExtensions.Randomization {

    /// <summary>
    /// Class for generating random numbers.
    /// </summary>
    public class Randomization : MonoBehaviour {

        /// <summary>
        /// Random number generator.
        /// </summary>
        private static System.Random r = new System.Random();

        /// <summary>
        /// Generates a random integer between min (inclusive) and max (exclusive).
        /// </summary>
        /// <returns>The integer.</returns>
        /// <param name="min">Minimum value (inclusive).</param>
        /// <param name="max">Maximum value (exclusive).</param>
        public static int RandomInt (int min, int max) { //Min is inclusive, Max is exclusive
            return r.Next(min, max);
        }

        /// <summary>
        /// Return a float between min (inclusive) and max (exclusive).
        /// </summary>
        /// <param name="min">Mimimum value (inclusive).</param>
        /// <param name="max">Maximum value (exclusive).</param>
        /// <returns></returns>
        public static float RandomFloat (float min, float max) {
            return (float)r.NextDouble() * (max - min) + min;
        }

        /// <summary>
        /// Generates a random boolean value.
        /// </summary>
        /// <returns>The boolean.</returns>
        public static bool RandomBool () {
            return (r.Next(0, 2) == 0 ? true : false); // Possible values are 0 and 1; generation is inclusive for lower bounds, exclusive for upper.
        }

        /// <summary>
        /// Return a Vector2 between the two Vector2s.
        /// </summary>
        /// <param name="min">Minimum values (inclusive).</param>
        /// <param name="max">Maximum values (exclusive).</param>
        /// <returns>Created Vector2.</returns>
        public static Vector2 RandomVector2 (Vector2 min, Vector2 max) {
            return new Vector2(RandomFloat(min.x, max.x), RandomFloat(min.y, max.y));
        }

        /// <summary>
        /// Return a Vector2 with values within the given ranges.
        /// </summary>
        /// <param name="minX">Mimimum x value (inclusive).</param>
        /// <param name="maxX">Maximum x value (exclusive).</param>
        /// <param name="minY">Mimimum y value (inclusive).</param>
        /// <param name="maxY">Maximum y value (exclusive).</param>
        /// <returns>Created Vector2.</returns>
        public static Vector2 RandomVector2 (float minX, float maxX, float minY, float maxY) {
            return new Vector2(RandomFloat(minX, maxX), RandomFloat(minY, maxY));
        }

        /// <summary>
        /// Randomly select an object from <paramref name="list" />.
        /// </summary>
        /// <param name="list">List of objects to choose from.</param>
        /// <typeparam name="T">Type of object in <paramref name="list" />.</typeparam>
        /// <returns>Selected object from <paramref name="list" /> or default(<typeparamref name="T" />) if <paramref name="list" /> is null or empty.</returns>
        public static T RandomFromList<T> (IList<T> list) {
            if (list == null || list.Count == 0) return default(T);
            if (list.Count == 1) return list[0];

            return list[RandomInt(0, list.Count)];
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
        public static T RandomFromWeightedList<T> (IList<KeyValuePair<T, int>> list) {
            if (list == null || list.Count == 0) return default(T);
            if (list.Count == 1) return (list[0].Value > 0 ? list[0].Key : default(T));

            int totalWeight = 0;
            for (int index = 0; index < list.Count; index++) {
                totalWeight += list[index].Value;
            }

            int resultValue = RandomInt(0, totalWeight);
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
