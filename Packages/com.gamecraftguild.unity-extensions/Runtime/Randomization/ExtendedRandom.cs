using UnityEngine;

namespace GameCraftGuild.UnityExtensions.Randomization {

    /// <summary>
    /// Static class that uses Unity's Random number generator to more easily create Unity data structs with random values.
    /// For example creating a random Vector2, Vector3, or Color.
    /// </summary>
    public static class ExtendedRandom {

        /// <summary>
        /// Return a Vector2 between the min and max values.
        /// </summary>
        /// <param name="min">Minimum values (inclusive).</param>
        /// <param name="max">Maximum values (inclusive).</param>
        /// <returns>A Vector2 with random values within constraints.</returns>
        public static Vector2 Vector2 (Vector2 min, Vector2 max) {
            return new Vector2(Random.Range(min.x, max.x), Random.Range(min.y, max.y));
        }

        /// <summary>
        /// Return a Vector2 with values within the given ranges.
        /// </summary>
        /// <param name="minX">Minimum x value (inclusive).</param>
        /// <param name="maxX">Maximum x value (inclusive).</param>
        /// <param name="minY">Minimum y value (inclusive).</param>
        /// <param name="maxY">Maximum y value (inclusive).</param>
        /// <returns>A Vector2 with random values within constraints.</returns>
        public static Vector2 Vector2 (float minX, float maxX, float minY, float maxY) {
            return new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        }

        /// <summary>
        /// Return a random Color within the given ranges with an alpha of 1.
        /// </summary>
        /// <param name="min">Min values for the color. RGB corresponds to XYZ. (inclusive)</param>
        /// <param name="max">Max values for the color. RGB corresponds to XYZ. (inclusive)</param>
        /// <returns>A random Color between the given values.</returns>
        public static Color Color (Vector3 min, Vector3 max) {
            return new Color(Mathf.Clamp(Random.Range(min.x, max.x), 0, 1), Mathf.Clamp(Random.Range(min.y, max.y), 0, 1), Mathf.Clamp(Random.Range(min.z, max.z), 0, 1), 1f);
        }

        /// <summary>
        /// Return a random Color within the given ranges with an alpha of 1.
        /// </summary>
        /// <param name="minR">Min R value. (inclusive)</param>
        /// <param name="minG">Min G value. (inclusive)</param>
        /// <param name="minB">Min B value. (inclusive)</param>
        /// <param name="maxR">Max R value. (inclusive)</param>
        /// <param name="maxG">Max G value. (inclusive)</param>
        /// <param name="maxB">Max B value. (inclusive)</param>
        /// <returns>A random color between the given values.</returns>
        public static Color Color (float minR, float minG, float minB, float maxR, float maxG, float maxB) {
            return new Color(Mathf.Clamp(Random.Range(minR, maxR), 0, 1), Mathf.Clamp(Random.Range(minG, maxG), 0, 1), Mathf.Clamp(Random.Range(minB, maxB), 0, 1), 1f);
        }

        /// <summary>
        /// Return a random Color with a random alpha between the given ranges.
        /// </summary>
        /// <param name="min">Min values for the color. RGBA corresponds to XYZW. (inclusive)</param>
        /// <param name="max">Max values for the color. RGBA corresponds to XYZW. (inclusive)</param>
        /// <returns>A random Color between the given values.</returns>
        public static Color ColorAlpha (Vector4 min, Vector4 max) {
            return new Color(Mathf.Clamp(Random.Range(min.x, max.x), 0, 1), Mathf.Clamp(Random.Range(min.y, max.y), 0, 1), Mathf.Clamp(Random.Range(min.z, max.z), 0, 1), Mathf.Clamp(Random.Range(min.w, max.w), 0, 1));
        }

        /// <summary>
        /// Return a random Color with a random alpha between the given ranges.
        /// </summary>
        /// <param name="minR">Min R value. (inclusive)</param>
        /// <param name="minG">Min G value. (inclusive)</param>
        /// <param name="minB">Min B value. (inclusive)</param>
        /// <param name="minA">Min A value. (inclusive)</param>
        /// <param name="maxR">Max R value. (inclusive)</param>
        /// <param name="maxG">Max G value. (inclusive)</param>
        /// <param name="maxB">Max B value. (inclusive)</param>
        /// <param name="maxA">Max A value. (inclusive)</param>
        /// <returns>A random Color between the given values.</returns>
        public static Color ColorAlpha (float minR, float minG, float minB, float minA, float maxR, float maxG, float maxB, float maxA) {
            return new Color(Mathf.Clamp(Random.Range(minR, maxR), 0, 1), Mathf.Clamp(Random.Range(minG, maxG), 0, 1), Mathf.Clamp(Random.Range(minB, maxB), 0, 1), Mathf.Clamp(Random.Range(minA, maxA), 0, 1));
        }

        /// <summary>
        /// Return a random greyscale Color (r == g == b) between the given values with an alpha of 1.
        /// </summary>
        /// <param name="min">Min value. (inclusive)</param>
        /// <param name="max">Max value. (inclusive)</param>
        /// <returns>A random greyscale Color between the given values.</returns>
        public static Color Greyscale (float min, float max) {
            float value = Mathf.Clamp(Random.Range(min, max), 0, 1);
            return new Color(value, value, value, 1f);
        }

        /// <summary>
        /// Return a random greyscale Color (r == g == b) between the given values with a random alpha between the given values.
        /// </summary>
        /// <param name="min">Min color value. (inclusive)</param>
        /// <param name="max">Max color value. (inclusive)</param>
        /// <param name="minAlpha">Min alpha value. (inclusive)</param>
        /// <param name="maxAlpha">Max alpha value. (inclusive)</param>
        /// <returns>A random greyscale color between the given values with an alpha between the given values.</returns>
        public static Color GreyscaleAlpha (float min, float max, float minAlpha, float maxAlpha) {
            float value = Mathf.Clamp(Random.Range(min, max), 0, 1);
            return new Color(value, value, value, Mathf.Clamp(Random.Range(minAlpha, maxAlpha), 0, 1));
        }

    }
}
