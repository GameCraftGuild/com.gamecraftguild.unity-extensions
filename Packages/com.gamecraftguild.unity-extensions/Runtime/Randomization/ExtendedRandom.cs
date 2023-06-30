using UnityEditor.Graphs;
using UnityEngine;

namespace GameCraftGuild.UnityExtensions.Randomization
{
    /// <summary>
    /// Static class that uses Unity's Random number generator to more easily create Unity data structs with random values.
    /// For example creating a random Vector2, Vector3, or Color.
    /// </summary>
    public static class ExtendedRandom
    {
        /// <summary>
        /// Return a Vector2 between the min and max values.
        /// </summary>
        /// <param name="min">Minimum values (inclusive).</param>
        /// <param name="max">Maximum values (inclusive).</param>
        /// <returns>A Vector2 with random values within constraints.</returns>
        public static Vector2 Vector2(Vector2 min, Vector2 max)
        {
            return ExtendedRandom.Vector2(min.x, min.y, max.x, max.y);
        }
        
        /// <summary>
        /// Return a Vector3 between the min and max values.
        /// </summary>
        /// <param name="min">Minimum values (inclusive).</param>
        /// <param name="max">Maximum values (inclusive).</param>
        /// <returns>A Vector3 with random values within constraints.</returns>
        public static Vector3 Vector3(Vector3 min, Vector3 max)
        {
            return ExtendedRandom.Vector3(min.x, min.y, min.z, max.x, max.y, max.z);
        }
        
        /// <summary>
        /// Return a Vector4 between the min and max values.
        /// </summary>
        /// <param name="min">Minimum values (inclusive).</param>
        /// <param name="max">Maximum values (inclusive).</param>
        /// <returns>A Vector4 with random values within constraints.</returns>
        public static Vector4 Vector4(Vector4 min, Vector4 max)
        {
            return ExtendedRandom.Vector4(min.x, min.y, min.z, min.w, max.x, max.y, max.z, max.w);
        }

        /// <summary>
        /// Return a Vector2 with values within the given ranges.
        /// </summary>
        /// <param name="minX">Minimum x value (inclusive).</param>
        /// <param name="minY">Minimum y value (inclusive).</param>
        /// <param name="maxX">Maximum x value (inclusive).</param>
        /// <param name="maxY">Maximum y value (inclusive).</param>
        /// <returns>A Vector2 with random values within constraints.</returns>
        public static Vector2 Vector2(float minX, float minY, float maxX, float maxY)
        {
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);
            return new Vector2(x, y);
        }
        
        /// <summary>
        /// Return a Vector3 with values within the given ranges.
        /// </summary>
        /// <param name="minX">Minimum x value (inclusive).</param>
        /// <param name="minY">Minimum y value (inclusive).</param>
        /// <param name="minZ">Minimum z value (inclusive).</param>
        /// <param name="maxX">Maximum x value (inclusive).</param>
        /// <param name="maxY">Maximum y value (inclusive).</param>
        /// <param name="maxZ">Maximum z value (inclusive).</param>
        /// <returns>A Vector3 with random values within constraints.</returns>
        public static Vector3 Vector3(float minX, float minY, float minZ, float maxX, float maxY, float maxZ)
        {
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);
            float z = Random.Range(minZ, maxZ);
            return new Vector3(x, y, z);
        }

        /// <summary>
        /// Return a Vector4 with values within the given ranges.
        /// </summary>
        /// <param name="minX">Minimum x value (inclusive).</param>
        /// <param name="minY">Minimum y value (inclusive).</param>
        /// <param name="minZ">Minimum z value (inclusive).</param>
        /// <param name="minW">Minimum w value (inclusive).</param>
        /// <param name="maxX">Maximum x value (inclusive).</param>
        /// <param name="maxY">Maximum y value (inclusive).</param>
        /// <param name="maxZ">Maximum z value (inclusive).</param>
        /// <param name="maxW">Maximum w value (inclusive).</param>
        /// <returns>A Vector4 with random values within constraints.</returns>
        public static Vector4 Vector4(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
        {
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);
            float z = Random.Range(minZ, maxZ);
            float w = Random.Range(minW, maxW);
            return new Vector4(x, y, z, w);
        }

        /// <summary>
        /// Return a random Color within the given ranges with an alpha of 1.
        /// </summary>
        /// <param name="min">Min values for the color. (inclusive)</param>
        /// <param name="max">Max values for the color. (inclusive)</param>
        /// <returns>A random Color between the given values.</returns>
        public static Color Color(Color min, Color max)
        {
            return ExtendedRandom.Color(min.r, min.g, min.b, min.a, max.r, max.g, max.b, max.a);
        }

        /// <summary>
        /// Return a random Color within the given ranges with an alpha of 1.
        /// </summary>
        /// <param name="minR">Min R value. (inclusive)</param>
        /// <param name="minG">Min G value. (inclusive)</param>
        /// <param name="minB">Min B value. (inclusive)</param>
        /// <param name="minA">Min A value. (inclusive)</param>
        /// <param name="maxR">Max R value. (inclusive)</param>
        /// <param name="maxG">Max G value. (inclusive)</param>
        /// <param name="maxB">Max B value. (inclusive)</param>
        /// <param name="maxA">Max A value. (inclusive)</param>
        /// <returns>A random color between the given values.</returns>
        public static Color Color(
            float minR = 0f, 
            float minG = 0f, 
            float minB = 0f, 
            float minA = 0f, 
            float maxR = 1f, 
            float maxG = 1f,
            float maxB = 1f, 
            float maxA = 1f)
        {
            float r = Mathf.Clamp(Random.Range(minR, maxR), 0, 1);
            float g = Mathf.Clamp(Random.Range(minG, maxG), 0, 1);
            float b = Mathf.Clamp(Random.Range(minB, maxB), 0, 1);
            float a = Mathf.Clamp(Random.Range(minA, maxA), 0, 1);
            return new Color(r, g, b, a);
        }

        /// <summary>
        /// Return a random greyscale Color (r == g == b) between the given values with an alpha of 1.
        /// </summary>
        /// <param name="min">Min value. (inclusive)</param>
        /// <param name="max">Max value. (inclusive)</param>
        /// <returns>A random greyscale Color between the given values.</returns>
        public static Color GreyscaleColor(float min = 0f, float max = 1f)
        {
            float greyScaleValue = Mathf.Clamp(Random.Range(min, max), 0, 1);
            return new Color(greyScaleValue, greyScaleValue, greyScaleValue, 1f);
        }
    }
}