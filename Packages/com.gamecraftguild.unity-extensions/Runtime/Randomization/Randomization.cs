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

    }
}
