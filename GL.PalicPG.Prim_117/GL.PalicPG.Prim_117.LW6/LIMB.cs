
namespace GL.PalicPG.Prim_117.LW6
{
    public class LIMB
    {
        public LIMB(int a, int b)
        {
            if (temp[0] == 0)
                temp[0] = 1;
            VandF[0] = a;
            VandF[1] = b;
            Memcompl();
        }

        public int Itog;
        public float[,] vert;
        public int[,] face;
        public float[,] t_vert;
        public int[,] t_face;
        public int MaterialNom = -1;
        public int[] VandF = new int[4];
        private int[] temp = new int[2];
        private bool ModelHasTexture = false;

        public bool NeedTexture() => ModelHasTexture;

        public void CreateTextureVertexMem(int a)
        {
            VandF[2] = a;
            t_vert = new float[3, VandF[2]];
        }

        public void CreateTextureFaceMem(int b)
        {
            VandF[3] = b;
            t_face = new int[3, VandF[3]];
            ModelHasTexture = true;
        }

        private void Memcompl()
        {
            vert = new float[3, VandF[0]];
            face = new int[3, VandF[1]];
        }

        public int GetTextureNom() => MaterialNom;

    }
}
