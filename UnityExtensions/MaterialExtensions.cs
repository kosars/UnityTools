using UnityEngine;

namespace kosars.UnityExtensions
{
	public static class MaterialExtensions
	{
		public static void SetAlpha(this Material material, float alpha) {
			material.color = material.color.SetAlpha(alpha);
		}
	}
}