using Course.Building.Palic.Enums;
using Course.Building.Palic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Course.Building.Palic.CameraOptions
{
    class Camera
    {
        // Место нахождения камеры
        public Point Position;

        // Наклон
        public Point Incline;

        // Тут поставим камеру куда надо, с учётом разой ерунды типа проекции
        public void SetCamera(Projection projection)
        {
            // активация проекционной матрицы
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            // очистка матрицы
            Gl.glLoadIdentity();

            if (projection == Projection.Perspective)
            {
                Glu.gluPerspective(45, 1, 0.1, 5000); // первый параметр угл, последний параметр это насколько далеко будет видно объект по осям.
            }
            /*else if (projection == Projection.Orthogonal)
            {
                Gl.glOrtho(orthoProjection.left, orthoProjection.right, orthoProjection.bottom, orthoProjection.top, orthoProjection.zNear, orthoProjection.zFar);
            }
            else if (projection == Projection.Frustum)
            {
                Gl.glFrustum(frustumProjection.left, frustumProjection.right, frustumProjection.bottom, frustumProjection.top, frustumProjection.zNear, frustumProjection.zFar);
            }*/

            Gl.glTranslated(this.Position.X, this.Position.Y, this.Position.Z);
            Gl.glRotated(Incline.X, 1, 0, 0);
            Gl.glRotated(Incline.Y, 0, 1, 0);
            Gl.glRotated(Incline.Z, 0, 0, 1);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
        }
    }
}
