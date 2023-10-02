using System.Collections;
using UnityEngine;

namespace kosars.UnityExtensions
{
    public class EaseTestExample
    {
        public static void DoTest() {
            float t = Random.value;
            float easedT = Ease.SinusoidalIn.Evaluate(t);
            Debug.Log($"t: {t}, easedT: {easedT}");

            Ease easeOut = Ease.SinusoidalOut;
            float otherEasedT = easeOut.Evaluate(t);
            Debug.Log($"t: {t}, easedT2: {otherEasedT}");
        }
    }
}