using System.Collections;
using UnityEngine;

namespace kosars.UnityExtensions
{
    public static class Randomization
    {
        public static Vector2 Vector2(float minX = 0f, float maxX = 1f, float minY = 0f, float maxY = 1f) {
            return new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        }

        public static Vector3 Vector3(float minX = 0f, float maxX = 1f, float minY = 0f, float maxY = 1f, float minZ = 0f, float maxZ = 1f) {
            return new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        }
    }
}