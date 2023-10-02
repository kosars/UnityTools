using System;
using UnityEngine;

namespace kosars.UnityExtensions
{
    public static class VectorExtensions
    {
        public static Vector2 ToVector2(this Vector2Int v) => v;

        public static Vector3 ToVector3(this Vector3Int v) => v;

        static public Color ToColorRGB(this Vector3 v) => new Color(v.x, v.y, v.z);

        static public float Cross(this Vector2 a, Vector2 b) {
            return a.x * b.y - a.y * b.x;
        }

        static public Vector2 Abs(this Vector2 a) {
            return new Vector2(Mathf.Abs(a.x), Mathf.Abs(a.y));
        }

        public static Vector3 SetX(this Vector3 v, float x) {
            return new Vector3(x, v.y, v.z);
        }

        public static Vector3 SetY(this Vector3 v, float y) {
            return new Vector3(v.x, y, v.z);
        }

        public static Vector3 SetZ(this Vector3 v, float z) {
            return new Vector3(v.x, v.y, z);
        }

        public static Vector2 SetX(this Vector2 v, float x) {
            return new Vector2(x, v.y);
        }

        public static Vector2 SetY(this Vector2 v, float y) {
            return new Vector2(v.x, y);
        }

        static public Vector3 Xyz(this Vector2 v, float z) {
            return new Vector3(v.x, v.y, z);
        }

        static public Vector3Int Xyz(this Vector2Int v, int z) {
            return new Vector3Int(v.x, v.y, z);
        }

        public static Vector2 Xy(this Vector3 v) {
            return new Vector2(v.x, v.y);
        }

        public static Vector2Int Xy(this Vector3Int v) {
            return new Vector2Int(v.x, v.y);
        }

        public static Vector2 Xz(this Vector3 v) {
            return new Vector2(v.x, v.z);
        }

        public static Vector3 XyToXz(this Vector2 v, float y = 0) {
            return new Vector3(v.x, y, v.y);
        }

        public static Vector2 XzToXy(this Vector3 v) {
            return new Vector2(v.x, v.z);
        }

        public static Vector2Int RoundToInt(this Vector2 v) {
            return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
        }

        public static Vector3Int RoundToInt(this Vector3 v) {
            return new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));
        }

        public static Vector2Int FloorToInt(this Vector2 v) {
            return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
        }

        public static Vector3Int FloorToInt(this Vector3 v) {
            return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
        }

        public static Vector2 Rotate90Clockwise(this Vector2 v) {
            return new Vector2(v.y, -v.x);
        }

        public static Vector2Int Rotate90Clockwise(this Vector2Int v) {
            return new Vector2Int(v.y, -v.x);
        }

        public static Vector2 Rotate90CounterClockwise(this Vector2 v) {
            return new Vector2(-v.y, v.x);
        }

        public static Vector2Int Rotate90CounterClockwise(this Vector2Int v) {
            return new Vector2Int(-v.y, v.x);
        }

        public static float AngleDegress(this Vector2 a, Vector2 b) {
            Vector2 c = b - a;
            float angle = Mathf.Atan2(c.y, c.x);
            return angle * Mathf.Rad2Deg;
        }
    }
}
