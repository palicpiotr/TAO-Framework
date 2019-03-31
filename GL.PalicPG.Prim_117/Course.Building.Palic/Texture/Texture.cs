using System;
using Tao.DevIl;
using Tao.OpenGl;

namespace Course.Building.Palic.Texture
{
    class Texture
    {
        public string url { get; set; }// адрес изображения
        public int imageId = 0;// { get; set; }
        public uint mGlTextureObject = 0;// { get; set; }

        public Texture(string url)
        {
            this.url = url;
            this.LoadTexture();
        }
        private void LoadTexture()
        {
            string url = this.url;

            // создаем изображение с идентификатором imageId
            Il.ilGenImages(1, out imageId);
            // делаем изображение текущим
            Il.ilBindImage(imageId);
            // пробуем загрузить изображение
            if (Il.ilLoadImage(url))
            {
                // если загрузка прошла успешно
                // сохраняем размеры изображения
                int width = Il.ilGetInteger(Il.IL_IMAGE_WIDTH);
                int height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT);

                // определяем число бит на пиксель
                int bitspp = Il.ilGetInteger(Il.IL_IMAGE_BITS_PER_PIXEL);

                if (bitspp == 24) // в зависимости от полученного результата
                    this.mGlTextureObject = MakeGlTexture(Gl.GL_RGB, Il.ilGetData(), width, height); // создаем текстуру, используя режим GL_RGB
                else if (bitspp == 32)
                    this.mGlTextureObject = MakeGlTexture(Gl.GL_RGBA, Il.ilGetData(), width, height); // GL_RGBA

                // очищаем память
                Il.ilDeleteImages(1, ref imageId);

            }
        }
        // создание текстуры в памяти openGL
        private static uint MakeGlTexture(int Format, IntPtr pixels, int w, int h)
        {
            // идентификатор текстурного объекта
            uint texObject;

            // генерируем текстурный объект
            Gl.glGenTextures(1, out texObject);

            // устанавливаем режим упаковки пикселей
            Gl.glPixelStorei(Gl.GL_UNPACK_ALIGNMENT, 1);

            // создаем привязку к только что созданной текстуре
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texObject);

            // устанавливаем режим фильтрации и повторения текстуры
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE);

            // создаем RGB или RGBA текстуру
            if (Format == Gl.GL_RGB)
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, w, h, 0, Gl.GL_RGB, Gl.GL_UNSIGNED_BYTE, pixels);
            else if (Format == Gl.GL_RGBA)
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, w, h, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, pixels);

            // возвращаем идентификатор текстурного объекта
            return texObject;
        }
    }
}
