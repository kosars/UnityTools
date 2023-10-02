using System.Collections.Generic;
using UnityEngine;

namespace kosars.UnityExtensions
{
    public static class TransformExtensions
    {
        public static void DestroyAllChildrens(this Transform t) {
            for(var i = t.childCount - 1; i >= 0; i--) {
                Object.Destroy(t.GetChild(i).gameObject);
            }
        }

        public static void ResetTransform(this Transform t) {
            t.position = Vector3.zero;
            t.localRotation = Quaternion.identity;
            t.localScale = Vector3.one;
        }

        /// <summary>
        /// Change Transform's parent keeping scale and position
        /// </summary>
        public static void Reparent(this Transform child, Transform parent) {
            var localPos = child.localPosition;
            var localRotation = child.localRotation;
            var scale = child.localScale;

#if UNITY_4_6 || UNITY_5
			child.SetParent(parent);
#else
            child.parent = parent;
#endif

            child.localPosition = localPos;
            child.localRotation = localRotation;
            child.localScale = scale;
        }

        /// <summary>
        /// IEnumerable of child tranforms
        /// </summary>
        public static IEnumerable<Transform> GetChildren(this Transform t) {
            for(var i = 0; i < t.childCount; ++i)
                yield return t.GetChild(i);
        }

        public static void SetLocalX(this Transform t, float x) {
            t.localPosition = new Vector3(x, t.localPosition.y, t.localPosition.z);
        }

        public static void SetLocalY(this Transform t, float y) {
            t.localPosition = new Vector3(t.localPosition.x, y, t.localPosition.z);
        }

        public static void SetLocalZ(this Transform t, float z) {
            t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, z);
        }

        public static void SetWorldX(this Transform t, float x) {
            t.position = new Vector3(x, t.position.y, t.position.z);
        }

        public static void SetWorldY(this Transform t, float y) {
            t.position = new Vector3(t.position.x, y, t.position.z);
        }

        public static void SetWorldZ(this Transform t, float z) {
            t.position = new Vector3(t.position.x, t.position.y, z);
        }

        public static void SetLocalScale(this Transform t, float scale) {
            t.localScale = new Vector3(scale, scale, scale);
        }

        public static void SetLocalScaleX(this Transform t, float scaleX) {
            t.localScale = new Vector3(scaleX, t.localScale.y, t.localScale.z);
        }

        public static void SetLocalScaleY(this Transform t, float scaleY) {
            t.localScale = new Vector3(t.localScale.x, scaleY, t.localScale.z);
        }

        public static void SetLocalScaleZ(this Transform t, float scaleZ) {
            t.localScale = new Vector3(t.localScale.x, t.localScale.y, scaleZ);
        }

        public static void SetLocalZRotation(this Transform t, float angleInDegrees) {
            t.localRotation = Quaternion.AngleAxis(angleInDegrees, Vector3.forward);
        }
    }
}