using System.Collections.Generic;
using UnityEngine;

namespace kosars.UnityExtensions
{
	public static class ComponentExtensions
    {
		/// <summary>
		/// Attaches a component to the given component's game object.
		/// </summary>
		/// <param name="component">Component.</param>
		/// <returns>Newly attached component.</returns>
		public static T AddComponent<T>(this Component component) where T : Component {
			return component.gameObject.AddComponent<T>();
		}

		/// <summary>
		/// Gets a component attached to the given component's game object.
		/// If one isn't found, a new one is attached and returned.
		/// </summary>
		/// <param name="component">Component.</param>
		/// <returns>Previously or newly attached component.</returns>
		public static T GetOrAddComponent<T>(this Component component) where T : Component {
			return component.GetComponent<T>() ?? component.AddComponent<T>();
		}

		/// <summary>
		/// Checks whether a component's game object has a component of type T attached.
		/// </summary>
		/// <param name="component">Component.</param>
		/// <returns>True when component is attached.</returns>
		public static bool HasComponent<T>(this Component component) where T : Component {
			return component.GetComponent<T>() != null;
		}
	}

	public static class GameObjectExtensions
	{
		/// <summary>
		/// Gets a component attached to the given game object.
		/// If one isn't found, a new one is attached and returned.
		/// </summary>
		/// <param name="gameObject">Game object.</param>
		/// <returns>Previously or newly attached component.</returns>
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component {
			return gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
		}

		/// <summary>
		/// Checks whether a game object has a component of type T attached.
		/// </summary>
		/// <param name="gameObject">Game object.</param>
		/// <returns>True when component is attached.</returns>
		public static bool HasComponent<T>(this GameObject gameObject) where T : Component {
			return gameObject.GetComponent<T>() != null;
		}

		public static GameObject FindChildRecoursively(this GameObject gameObject, string name) {
			var tr = gameObject.transform.Find(name);
			if(tr != null)
				return tr.gameObject;

			for(int i = 0; i < gameObject.transform.childCount; ++i) {
				var go = gameObject.transform.GetChild(i).gameObject;
				var found = FindChildRecoursively(go, name);
				if(found != null)
					return found;
			}
			return null;
		}

		/// <summary>
		/// Set Layer for gameobject and all of its children
		/// </summary>
		public static void SetLayerRecursively(this GameObject gameObject, int layer) {
			gameObject.layer = layer;

			foreach(var ch in gameObject.transform)
				((Transform)ch).gameObject.SetLayerRecursively(layer);
		}

		/// <summary>
		/// IEnumerable of child gameobjects
		/// </summary>
		public static IEnumerable<GameObject> GetChildren(this GameObject gameObject) {
			for(int i = 0; i < gameObject.transform.childCount; ++i)
				yield return gameObject.transform.GetChild(i).gameObject;
		}

		/// <summary>
		/// Find components of type T in childs (non-recousevly)
		/// </summary>
		public static T[] GetChildrenComponents<T>(this GameObject gameObject) where T : Component {
			var components = new List<T>();

			for(var i = 0; i < gameObject.transform.childCount; i++) {
				var c = gameObject.transform.GetChild(i).gameObject.GetComponent<T>();
				if(c != null)
					components.Add(c);
			}

			return components.ToArray();
		}

		public static GameObject[] GetChildrenArray(this GameObject gameObject) {
			Transform transform = gameObject.transform;
			GameObject[] objs = new GameObject[transform.childCount];
			int i = 0;
			foreach(Transform t in transform)
				objs[i++] = t.gameObject;
			return objs;
		}

		public static void SetLayerIncludeChildren(this GameObject gameObject, int layer) {
			gameObject.layer = layer;
			foreach(Transform child in gameObject.transform)
				child.gameObject.SetLayerIncludeChildren(layer);
		}
	}
}