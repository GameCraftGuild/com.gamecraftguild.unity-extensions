using System.Collections.Generic;
using UnityEngine;

namespace GameCraftGuild.UnityExtensions.Randomization {

    /// <summary>
    /// Class for generating random numbers.
    /// </summary>
    public class Randomization {

        /// <summary>
        /// Return a Vector2 between the two Vector2s.
        /// </summary>
        /// <param name="min">Minimum values (inclusive).</param>
        /// <param name="max">Maximum values (inclusive).</param>
        /// <returns>Created Vector2.</returns>
        public static Vector2 RandomVector2 (Vector2 min, Vector2 max) {
            return new Vector2(Random.Range(min.x, max.x), Random.Range(min.y, max.y));
        }

        /// <summary>
        /// Return a Vector2 with values within the given ranges.
        /// </summary>
        /// <param name="minX">Mimimum x value (inclusive).</param>
        /// <param name="maxX">Maximum x value (inclusive).</param>
        /// <param name="minY">Mimimum y value (inclusive).</param>
        /// <param name="maxY">Maximum y value (inclusive).</param>
        /// <returns>Created Vector2.</returns>
        public static Vector2 RandomVector2 (float minX, float maxX, float minY, float maxY) {
            return new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        }

        /// <summary>
        /// Return a random Color with an alpha of 1.
        /// </summary>
        /// <returns>A random Color.</returns>
        public static Color RandomColor () {
            return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }

        /// <summary>
        /// Return a random Color with a random alpha value.
        /// </summary>
        /// <returns>A random Color.</returns>
        public static Color RandoColorAlpha () {
            return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }

        /// <summary>
        /// Return a random greyscale Color (r == g == b) with an alpha of 1.
        /// </summary>
        /// <returns>A random greyscale Color.</returns>
        public static Color RandomGreyscale () {
            float value = Random.Range(0f, 1f);
            return new Color(value, value, value);
        }

        /// <summary>
        /// Return a random greyscale Color (r == g == b) with a random alpha.
        /// </summary>
        /// <returns>A random greyscale Color.</returns>
        public static Color RandomGreyscaleAlpha () {
            float value = Random.Range(0f, 1f);
            return new Color(value, value, value, Random.Range(0f, 1f));
        }

    }
}
