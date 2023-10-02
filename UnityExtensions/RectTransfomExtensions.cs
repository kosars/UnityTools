using UnityEngine;

namespace kosars.UnityExtensions
{
    public static class RectTransfomExtensions
    {
        public static void SetAnchoredX(this RectTransform rt, float x) {
            rt.anchoredPosition = rt.anchoredPosition.SetX(x);
        }

        public static void SetAnchoredY(this RectTransform rt, float y) {
            rt.anchoredPosition = rt.anchoredPosition.SetY(y);
        }

        public static void SetAnchoredXY(this RectTransform rt, float x, float y) {
            rt.anchoredPosition = new Vector2(x, y);
        }

        public static void SetAnchoredXY(this RectTransform rt, Vector2 xy) {
            rt.anchoredPosition = xy;
        }

        public static void SetSizeDeltaX(this RectTransform rt, float sizeDeltaX) {
            Vector2 sizeDelta = rt.sizeDelta;
            sizeDelta.x = sizeDeltaX;
            rt.sizeDelta = sizeDelta;
        }

        public static void SetSizeDeltaY(this RectTransform rt, float sizeDeltaY) {
            Vector2 sizeDelta = rt.sizeDelta;
            sizeDelta.y = sizeDeltaY;
            rt.sizeDelta = sizeDelta;
        }

        public static void SetLeft(this RectTransform rt, float left) {
            rt.offsetMin = new Vector2(left, rt.offsetMin.y);
        }

        public static void SetRight(this RectTransform rt, float right) {
            rt.offsetMax = new Vector2(-right, rt.offsetMax.y);
        }

        public static void SetTop(this RectTransform rt, float top) {
            rt.offsetMax = new Vector2(rt.offsetMax.x, -top);
        }

        public static void SetBottom(this RectTransform rt, float bottom) {
            rt.offsetMin = new Vector2(rt.offsetMin.x, bottom);
        }

        public static void SetSize(this RectTransform rt, Vector2 size) {
            SetSize(rt, size.x, size.y);
        }

        public static void SetSize(this RectTransform rt, float width, float height) {
            rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
            rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }

        public static void SetWidth(this RectTransform rt, float width) {
            rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        }

        public static void SetHeight(this RectTransform rt, float height) {
            rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }
    }
}