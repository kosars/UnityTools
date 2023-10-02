using UnityEngine;

namespace kosars.UnityExtensions
{
    public static class MeshExtensions
    {
        public static void SetColor(this Mesh mesh, Color color) {
            var colors = new Color[mesh.vertices.Length];
            for(int i = 0; i < colors.Length; i++)
                colors[i] = color;
            mesh.SetColors(colors);
        }

        public static void SetColor(this Mesh mesh, Color32 color) {
            var colors = new Color32[mesh.vertices.Length];
            for(int i = 0; i < colors.Length; i++)
                colors[i] = color;
            mesh.SetColors(colors);
        }

        public static void SetColor(this Mesh mesh, float h, float s, float v) {
            var color = Color.HSVToRGB(h, s, v);
            mesh.SetColor(color);
        }

        public static void SetAlpha(this Mesh mesh, float alpha) {
            var colors = new Color[mesh.vertices.Length];
            for(int i = 0; i < colors.Length; i++)
                colors[i] = colors[i].SetAlpha(alpha);
            mesh.SetColors(colors);
        }

        public static Color GetFirstColor(this Mesh mesh) {
            return mesh.colors[0];
        }

        public static Color32 GetFirstColor32(this Mesh mesh) {
            return mesh.colors32[0];
        }

        public static void GetFirstColorHSV(this Mesh mesh, out float h, out float s, out float v) {
            Color.RGBToHSV(mesh.colors[0], out h, out s, out v);
        }

        public static void SetColorToUVs(this Mesh mesh, int chanel, Color color) {
            var colors = new Vector4[mesh.vertices.Length];
            for(int i = 0; i < colors.Length; i++)
                colors[i] = color;
            mesh.SetUVs(chanel, colors);
        }
    }
}