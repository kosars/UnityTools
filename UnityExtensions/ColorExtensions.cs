using UnityEngine;
using UnityEngine.UI;

namespace kosars.UnityExtensions
{
    public static class ColorExtensions
    {
        public static Color SetAlpha(this Color color, float a) {
            return new Color(color.r, color.g, color.b, a);
        }

        public static Color SetBlue(this Color color, float b) {
            return new Color(color.r, color.g, b, color.a);
        }

        public static Color SetRed(this Color color, float r) {
            return new Color(r, color.g, color.b, color.a);
        }

        public static Color SetGreen(this Color color, float g) {
            return new Color(color.r, g, color.b, color.a);
        }

        public static Color SetGrey(this Color color, float grey) {
            return new Color(grey, grey, grey, color.a);
        }

        public static float GetGrey(this Color color) {
            return (color.r + color.g + color.b) / 3f;
        }

        public static string ToStringHexRGB(this Color color) {
            Color32 color32 = color;
            return color32.r.ToString("X2") + color32.g.ToString("X2") + color32.b.ToString("X2");
        }

        public static string ToStringHexARGB(this Color color) {
            Color32 color32 = color;
            return color32.a.ToString("X2") + color32.r.ToString("X2") + color32.g.ToString("X2") + color32.b.ToString("X2");
        }
    }

    public static class GraphicExtensions
    {
        public static void SetAlpha(this Graphic graphic, float alpha) {
            graphic.color = graphic.color.SetAlpha(alpha);
        }

        public static void SetColorWithountAlpha(this Graphic graphic, Color color) {
            float alpha = graphic.color.a;
            color.a = alpha;
            graphic.color = color;
        }
    }
}