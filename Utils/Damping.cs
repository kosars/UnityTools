using UnityEngine;

namespace kosars.UnityExtensions
{
    public static class Damping
    {
        public static float Damp(float a, float b, float lambda, float dt) {
            return Mathf.Lerp(a, b, 1f - Mathf.Exp(-lambda * dt));
        }

        public static Vector2 Damp(Vector2 a, Vector2 b, float lambda, float dt) {
            return Vector2.Lerp(a, b, 1f - Mathf.Exp(-lambda * dt));
        }

        public static Vector3 Damp(Vector3 a, Vector3 b, float lambda, float dt) {
            return Vector3.Lerp(a, b, 1f - Mathf.Exp(-lambda * dt));
        }

        public static Quaternion Damp(Quaternion a, Quaternion b, float lambda, float dt) {
            return Quaternion.Lerp(a, b, 1f - Mathf.Exp(-lambda * dt));
        }
    }
}