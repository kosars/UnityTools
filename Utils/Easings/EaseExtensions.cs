using UnityEngine;
using kosars.UnityExtensions.EaseFunctions;

namespace kosars.UnityExtensions
{
    public static class EaseExtensions
    {
        public static float Evaluate(this Ease ease, float t) {
            return ease switch {
                Ease.Linear => t,

                Ease.Standart => StandartCurves.standart.Evaluate(t),
                Ease.StandartAccelerate => StandartCurves.standartAccelerate.Evaluate(t),
                Ease.StandartDecelerate => StandartCurves.standartDecelerate.Evaluate(t),

                Ease.EmphasizedAccelerate => StandartCurves.emphasizedAccelerate.Evaluate(t),
                Ease.EmphasizedDecelerate => StandartCurves.emphasizedDecelerate.Evaluate(t),

                Ease.FastOutSlowIn => StandartCurves.legacy.Evaluate(t),
                Ease.FastOut => StandartCurves.legacyAccelerate.Evaluate(t),
                Ease.LinearOutSlowIn => StandartCurves.legacyDecelerate.Evaluate(t),

                Ease.SinusoidalIn => Sine.EaseIn(t),
                Ease.SinusoidalOut => Sine.EaseOut(t),
                Ease.SinusoidalInOut => Sine.EaseInOut(t),

                Ease.QuadraticIn => Quad.EaseIn(t),
                Ease.QuadraticOut => Quad.EaseOut(t),
                Ease.QuadraticInOut => Quad.EaseInOut(t),

                Ease.CubicIn => Cubic.EaseIn(t),
                Ease.CubicOut => Cubic.EaseOut(t),
                Ease.CubicInOut => Cubic.EaseInOut(t),

                Ease.ExponentialIn => Expo.EaseIn(t),
                Ease.ExponentialOut => Expo.EaseOut(t),
                Ease.ExponentialInOut => Expo.EaseInOut(t),

                Ease.CircularIn => Circ.EaseIn(t),
                Ease.CircularOut => Circ.EaseOut(t),
                Ease.CircularInOut => Circ.EaseInOut(t),

                Ease.ElasticIn => Elastic.EaseIn(t),
                Ease.ElasticOut => Elastic.EaseOut(t),
                Ease.ElasticInOut => Elastic.EaseInOut(t),

                Ease.BackIn => Back.EaseIn(t),
                Ease.BackOut => Back.EaseOut(t),
                Ease.BackInOut => Back.EaseInOut(t),

                Ease.BounceIn => Bounce.EaseIn(t),
                Ease.BounceOut => Bounce.EaseOut(t),
                Ease.BounceInOut => Bounce.EaseInOut(t),

                _ => t,
            };
        }

        public class StandartCurves
        {
            //https://m3.material.io/styles/motion/easing-and-duration/tokens-specs

            public static readonly CubicBezier standart = new CubicBezier(0.2f, 0f, 0f, 1f);
            public static readonly CubicBezier standartAccelerate = new CubicBezier(0.3f, 0f, 1f, 1f);
            public static readonly CubicBezier standartDecelerate = new CubicBezier(0f, 0f, 0f, 1f);

            public static readonly CubicBezier emphasizedAccelerate = new CubicBezier(0.3f, 0f, 0.8f, 0.15f);
            public static readonly CubicBezier emphasizedDecelerate = new CubicBezier(0.05f, 0.7f, 0.1f, 1f);
            
            public static readonly CubicBezier legacy = new CubicBezier(0.4f, 0f, 0.2f, 1f); //fastOutSlowIn
            public static readonly CubicBezier legacyAccelerate = new CubicBezier(0.4f, 0f, 1f, 1f); //fastOut
            public static readonly CubicBezier legacyDecelerate = new CubicBezier(0f, 0f, 0.2f, 1f); //linearOutSlowIn
        }

    }
}