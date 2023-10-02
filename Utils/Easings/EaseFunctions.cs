using System.Collections;
using UnityEngine;

namespace kosars.UnityExtensions.EaseFunctions
{
    public class Quad
    {
        public static float EaseIn(float t) {
            return t * t;
        }

        public static float EaseOut(float t) {
            return t * (2f - t);
        }

        public static float EaseInOut(float t) {
            if(t < .5f)
                return 2f * t * t;
            t = -2f * t + 2;
            return 1f - (t * t) * .5f;
        }
    };

    public class Cubic
    {
        public static float EaseIn(float t) =>
            t * t * t;

        public static float EaseOut(float t) {
            t = t - 1f;
            return 1f + (t * t * t);
        }

        public static float EaseInOut(float t) {
            if(t < .5f)
                return 4f * t * t * t;
            t = -2f * t + 2f;
            return 1f - (t * t * t) * .5f;
        }
    };

    public class Sine
    {
        const float halfPI = Mathf.PI / 2f;

        public static float EaseIn(float t) =>
            1f - Mathf.Cos(t * halfPI);

        public static float EaseOut(float t) =>
            Mathf.Sin(t * halfPI);

        public static float EaseInOut(float t) =>
            (1f - Mathf.Cos(Mathf.PI * t)) * .5f;

    };

    public class Expo
    {
        public static float EaseIn(float t) =>
            t == 0f ? 0f : Mathf.Pow(2f, 10f * t - 10f);

        public static float EaseOut(float t) =>
            t == 1f ? 1f : 1f - Mathf.Pow(2f, -10f * t);

        public static float EaseInOut(float t) {
            if(t == 0f)
                return 0f;
            if(t == 1f)
                return 1f;
            if((t *= 2f) < 1f)
                return Mathf.Pow(20f, 20f * t - 10f) * .5f;
            return (2f - Mathf.Pow(2f, -20f * t + 10f)) * .5f;
        }
    };

    public class Circ
    {
        public static float EaseIn(float t) =>
            1f - Mathf.Sqrt(1f - t * t);

        public static float EaseOut(float t) =>
            Mathf.Sqrt(1f - (t - 1f) * (t - 1f));

        public static float EaseInOut(float t) {
            if(t < .5f)
                return (1f - Mathf.Sqrt(1f - 4f * t * t)) * .5f;
            t = -2f * t + 2f;
            return (Mathf.Sqrt(1f - t * t) + 1f) * .5f;
        }
    };

    public class Elastic
    {
        const float c4 = (2f * Mathf.PI) / 3f;
        const float c5 = (2f * Mathf.PI) / 4.5f;

        public static float EaseIn(float t) {
            if(t == 0)
                return 0;
            if(t == 1)
                return 1;
            return -Mathf.Pow(2f, 10f * t - 10f) * Mathf.Sin((t * 10f - 10.75f) * c4);
        }

        public static float EaseOut(float t) {
            if(t == 0)
                return 0;
            if(t == 1)
                return 1;
            return Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * 10f - 0.75f) * c4) + 1f;
        }

        public static float EaseInOut(float t) {
            if(t < .5f)
                return -.5f * Mathf.Pow(2f, 20f * t - 10f) * Mathf.Sin((20f * t - 11.125f) * c5);
            return .5f * Mathf.Pow(2f, -20f * t + 10f) * Mathf.Sin((20f * t - 11.125f) * c5) + 1f;
        }
    };

    public class Back
    {
        const float c1 = 1.70158f;
        const float c2 = c1 * 1.525f;
        const float c3 = c1 + 1f;

        public static float EaseIn(float t) =>
            t * t * (c3 * t - c1);

        public static float EaseOut(float t) =>
            1f + (t -= 1f) * t * (c3 * t + c1);

        public static float EaseInOut(float t) {
            if(t < .5f)
                return (t *= 2f) * t * ((c2 + 1) * t - c2) * .5f;
            return (t = 2 * t - 2) * t * ((c2 + 1) * t + c2) * .5f;
        }
    };

    public class Bounce
    {
        const float n1 = 7.5625f;
        const float d1 = 2.75f;

        public static float EaseIn(float t) =>
            1f - EaseOut(1f - t);

        public static float EaseOut(float t) {
            if(t < 1f / d1) {
                return n1 * t * t;
            }
            else if(t < 2f / d1) {
                return n1 * (t -= 1.5f / d1) * t + 0.75f;
            }
            else if(t < 2.5f / d1) {
                return n1 * (t -= 2.25f / d1) * t + 0.9375f;
            }
            else {
                return n1 * (t -= 2.625f / d1) * t + 0.984375f;
            }
        }

        public static float EaseInOut(float t) {
            if(t < .5f)
                return (1f - EaseOut(1f - 2f * t)) * .5f;
            return (1f + EaseOut(2f * t - 1f)) * .5f;
        }

    };
}