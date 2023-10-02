using System;
using UnityEngine;

namespace kosars.UnityExtensions
{
    [Serializable]
    public class CubicBezier
    {
        private float p0;
        private float p1;
        private float p2;
        private float p3;

        public CubicBezier(float p0, float p1, float p2, float p3) {
            this.p0 = p0;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public float Evaluate(float t) {
            return CurveInterpolations.CubicBezier(t, p0, p1, p2, p3);
        }
    }

    public class CurveInterpolations
    {
        public static float CubicBezier(float t, float p0, float p1, float p2, float p3) {
            return CubicBezierP0(t, p0) + CubicBezierP1(t, p1) +
                CubicBezierP2(t, p2) + CubicBezierP3(t, p3);
        }

        private static float CubicBezierP0(float t, float p) {
            var k = 1f - t;
            return k * k * k * p;
        }

        private static float CubicBezierP1(float t, float p) {
            var k = 1f - t;
            return 3f * k * k * t * p;
        }

        private static float CubicBezierP2(float t, float p) {
            return 3f * (1f - t) * t * t * p;
        }

        private static float CubicBezierP3(float t, float p) {
            return t * t * t * p;
        }
    }
}