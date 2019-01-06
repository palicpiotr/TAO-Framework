using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace GL.PalicPG.Prim_117.LW2
{
    public partial class Form1 : Form
    {

        #region Private properties

        private float _rot1, _rot2;
        private double[,] _geom2x2 = new double[64, 3];
        private double[,,] _resGeometric3x3 = new double[64, 64, 3];
        private int _elementsCount = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        #region Objects Drawer

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();
            Gl.glTranslated(0, 0, -7 - trackBarSize.Value);
            Gl.glRotated(_rot1, 1, 0, 0);
            Gl.glRotated(_rot2, 0, 1, 0);
            Gl.glPointSize(5.0f);
            Gl.glColor3d(1, 0, 0);
            switch (comboBoxFigureStyle.SelectedIndex)
            {
                case 0:

                    switch (comboBoxRenderMode.SelectedIndex)
                    {
                        case 0:
                            {
                                Gl.glBegin(Gl.GL_POINTS);
                                for (int ax = 0; ax < _elementsCount; ax++)
                                    Gl.glVertex3d(_geom2x2[ax, 0], _geom2x2[ax, 1], _geom2x2[ax, 2]);
                                Gl.glEnd();
                            }
                            break;
                        case 1:

                            HardwareRender();
                            break;
                    }
                    break;
                case 1:

                    switch (comboBoxRenderMode.SelectedIndex)
                    {
                        case 0:
                            {
                                Gl.glBegin(Gl.GL_LINE_STRIP);
                                for (int ax = 0; ax < _elementsCount; ax++)
                                {
                                    int axt = ax;
                                    //if (!checkBox2D.Checked) // проверка на 2D режим
                                    //{
                                    //for (int bx = 0; bx < trackBarSmooth.Value; bx++)
                                    //{
                                    //    // зарисовка точек на первой плоскости
                                    //    Gl.glVertex3d(ResaultGeometric[ax, bx, 0], ResaultGeometric[ax, bx, 1], ResaultGeometric[ax, bx, 2]);

                                    //    axt = (ax + 1 != count_elements) ? ax + 1 : 0;
                                    //    {

                                    //        Gl.glVertex3d(ResaultGeometric[axt, bx, 0], ResaultGeometric[axt, bx, 1], ResaultGeometric[axt, bx, 2]);

                                    //        // поиск и зарисовка точки на следующей плоскости
                                    //        if (bx + 1 < trackBarSmooth.Value)
                                    //        {
                                    //            Gl.glVertex3d(ResaultGeometric[axt, bx + 1, 0], ResaultGeometric[axt, bx + 1, 1], ResaultGeometric[axt, bx + 1, 2]);
                                    //        }
                                    //        else
                                    //        {
                                    //            Gl.glVertex3d(ResaultGeometric[axt, bx, 0], ResaultGeometric[axt, bx, 1], ResaultGeometric[axt, bx, 2]);
                                    //        }
                                    //    }
                                    //}
                                    //}
                                    //else
                                    //{
                                    Gl.glVertex3d(_geom2x2[ax, 0], _geom2x2[ax, 1], _geom2x2[ax, 2]);
                                    if (ax == _elementsCount - 1) Gl.glVertex3d(_geom2x2[0, 0], _geom2x2[0, 1], _geom2x2[0, 2]);
                                    //}
                                }
                                Gl.glEnd();
                            }
                            break;
                        case 1:
                            HardwareRender();
                            break;
                    }
                    break;
                case 2:
                    switch (comboBoxRenderMode.SelectedIndex)
                    {
                        case 0:
                            {
                                Gl.glBegin(Gl.GL_QUADS);
                                for (int ax = 0; ax < _elementsCount; ax++)
                                {
                                    for (int bx = 0; bx < trackBarSmooth.Value; bx++)
                                    {
                                        double x1 = 0, x2 = 0, x3 = 0, x4 = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0, z1 = 0, z2 = 0, z3 = 0, z4 = 0;

                                        x1 = _resGeometric3x3[ax, bx, 0];
                                        y1 = _resGeometric3x3[ax, bx, 1];
                                        z1 = _resGeometric3x3[ax, bx, 2];

                                        if (ax + 1 < _elementsCount)
                                        {
                                            x2 = _resGeometric3x3[ax + 1, bx, 0];
                                            y2 = _resGeometric3x3[ax + 1, bx, 1];
                                            z2 = _resGeometric3x3[ax + 1, bx, 2];

                                            if (bx + 1 < trackBarSmooth.Value)
                                            {
                                                x3 = _resGeometric3x3[ax + 1, bx + 1, 0];
                                                y3 = _resGeometric3x3[ax + 1, bx + 1, 1];
                                                z3 = _resGeometric3x3[ax + 1, bx + 1, 2];
                                                x4 = _resGeometric3x3[ax, bx + 1, 0];
                                                y4 = _resGeometric3x3[ax, bx + 1, 1];
                                                z4 = _resGeometric3x3[ax, bx + 1, 2];
                                            }
                                            else
                                            {
                                                x3 = _resGeometric3x3[ax + 1, 0, 0];
                                                y3 = _resGeometric3x3[ax + 1, 0, 1];
                                                z3 = _resGeometric3x3[ax + 1, 0, 2];
                                                x4 = _resGeometric3x3[ax, 0, 0];
                                                y4 = _resGeometric3x3[ax, 0, 1];
                                                z4 = _resGeometric3x3[ax, 0, 2];
                                            }
                                        }
                                        else
                                        {
                                            x2 = _resGeometric3x3[0, bx, 0];
                                            y2 = _resGeometric3x3[0, bx, 1];
                                            z2 = _resGeometric3x3[0, bx, 2];

                                            if (bx + 1 < trackBarSmooth.Value)
                                            {
                                                x3 = _resGeometric3x3[0, bx + 1, 0];
                                                y3 = _resGeometric3x3[0, bx + 1, 1];
                                                z3 = _resGeometric3x3[0, bx + 1, 2];

                                                x4 = _resGeometric3x3[ax, bx + 1, 0];
                                                y4 = _resGeometric3x3[ax, bx + 1, 1];
                                                z4 = _resGeometric3x3[ax, bx + 1, 2];
                                            }
                                            else
                                            {
                                                x3 = _resGeometric3x3[0, 0, 0];
                                                y3 = _resGeometric3x3[0, 0, 1];
                                                z3 = _resGeometric3x3[0, 0, 2];

                                                x4 = _resGeometric3x3[ax, 0, 0];
                                                y4 = _resGeometric3x3[ax, 0, 1];
                                                z4 = _resGeometric3x3[ax, 0, 2];
                                            }
                                        }
                                        double n1 = 0, n2 = 0, n3 = 0;
                                        if (ax == 0)
                                        {
                                            n1 = (y2 - y1) * (z3 - z1) - (y3 - y1) * (z2 - z1);
                                            n2 = (z2 - z1) * (x3 - x1) - (z3 - z1) * (x2 - x1);
                                            n3 = (x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1);
                                        }
                                        else
                                        {
                                            n1 = (y4 - y3) * (z1 - z3) - (y1 - y3) * (z4 - z3);
                                            n2 = (z4 - z3) * (x1 - x3) - (z1 - z3) * (x4 - x3);
                                            n3 = (x4 - x3) * (y1 - y3) - (x1 - x3) * (y4 - y3);
                                        }
                                        double n5 = (double)Math.Sqrt(n1 * n1 + n2 * n2 + n3 * n3);
                                        n1 /= (n5 + 0.01);
                                        n2 /= (n5 + 0.01);
                                        n3 /= (n5 + 0.01);
                                        Gl.glNormal3d(-n1, -n2, -n3);
                                        Gl.glVertex3d(x1, y1, z1);
                                        Gl.glVertex3d(x2, y2, z2);
                                        Gl.glVertex3d(x3, y3, z3);
                                        Gl.glVertex3d(x4, y4, z4);
                                    }
                                }
                                Gl.glEnd();
                            }
                            break;
                        case 1:
                            HardwareRender();
                            break;
                    }
                    break;
            }
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
            Rotate();
        }

        #endregion

        #region GL render

        private void HardwareRender()
        {
            switch (comboBoxObjectType.SelectedIndex)
            {
                case 0:
                    {
                        if (comboBoxFigureStyle.SelectedIndex < 2) // если выбран стиль фигуры точечный или каркасный (в глут нет точечного торуса)
                            Glut.glutWireTorus(2.0 / (trackBarParam.Value / 2.0 + 0.5), (trackBarParam.Value + 5) / 2.0, trackBarSmooth.Value, trackBarSmooth.Value);
                        else
                            Glut.glutSolidTorus(2.0 / (trackBarParam.Value / 2.0 + 0.5), (trackBarParam.Value + 5) / 2.0, trackBarSmooth.Value, trackBarSmooth.Value);
                    }
                    break;
                case 1:
                    {
                        Glu.GLUquadric spherel = Glu.gluNewQuadric();

                        switch (comboBoxFigureStyle.SelectedIndex)
                        {
                            case 0:
                                Glu.gluQuadricDrawStyle(spherel, Glu.GLU_POINT); //Glu.GLU_SILHOUETTE Glu.GLU_FILL
                                break;
                            case 1:
                                Glu.gluQuadricDrawStyle(spherel, Glu.GLU_LINE);
                                break;
                            case 2:
                                Glu.gluQuadricDrawStyle(spherel, Glu.GLU_FILL); //Glu.GLU_SILHOUETTE Glu.GLU_FILL
                                break;
                        }
                        Glu.gluSphere(spherel, 5, trackBarSmooth.Value, trackBarSmooth.Value);
                    }
                    break;
                case 2: // хардварное Безье
                    {
                        double u1 = 0.0;
                        double u2 = 1.0;
                        int ustride = 3;
                        int uorder = 4;
                        double v1 = 0.0;
                        double v2 = 1.0;
                        int vstride = 12;
                        int vorder = 4;
                        int nu = trackBarSmooth.Value;
                        int nv = trackBarSmooth.Value;

                        int nu1 = 0;
                        int nu2 = nu;
                        int nv1 = 0;
                        int nv2 = nv;

                        Gl.glMap2d(Gl.GL_MAP2_VERTEX_3, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref _bezArr[0, 0, 0]);
                        Gl.glEnable(Gl.GL_MAP2_VERTEX_3);
                        Gl.glColor3d(0.0, 0.0, 1.0);

                        int style = Gl.GL_POINTS;
                        switch (comboBoxFigureStyle.SelectedIndex)
                        {
                            case 0 when comboBoxFigureStyle.SelectedIndex.GetType() == typeof(int):
                                style = Gl.GL_POINTS;
                                break;
                            case 1 when comboBoxFigureStyle.SelectedIndex.GetType() == typeof(int):
                                style = Gl.GL_LINE_STRIP;
                                break;
                            case 2 when comboBoxFigureStyle.SelectedIndex.GetType() == typeof(int):
                                style = Gl.GL_QUAD_STRIP;
                                break;
                        }
                        for (int k = nu1; k < nu2; k++)
                        {
                            Gl.glBegin(style);
                            for (int j = nv1; j <= nv2; j++)
                            {
                                Gl.glEvalCoord2d(u1 + k * (u2 - u1) / nu, v1 + j * (v2 - v1) / nv);
                                Gl.glEvalCoord2d(u1 + (k + 1) * (u2 - u1) / nu, v1 + j * (v2 - v1) / nv);
                            }
                            Gl.glEnd();
                        }

                        /* START render source points */

                        Gl.glDisable(Gl.GL_LIGHTING);
                        Gl.glBegin(Gl.GL_POINTS);
                        Gl.glColor3d(1, 0, 0);
                        // выводим всю ранее просчитанную геометрию объекта
                        for (int ax = 0; ax < _bezArr.GetLength(0); ax++)
                        {
                            for (int bx = 0; bx < _bezArr.GetLength(1); bx++)
                            {
                                // отрисовка точки
                                Gl.glVertex3d(_bezArr[ax, bx, 0], _bezArr[ax, bx, 1], _bezArr[ax, bx, 2]);
                            }
                        }
                        Gl.glEnd();
                        Gl.glEnable(Gl.GL_LIGHTING);
                    }
                    break;
                case 3 when 3.GetType() == typeof(int): // Хардовый Би-сплайн
                    {
                        Glu.GLUnurbs bezSurface = Glu.gluNewNurbsRenderer();
                        switch (comboBoxFigureStyle.SelectedIndex)
                        {
                            case 2:
                                Glu.gluNurbsProperty(bezSurface, Glu.GLU_DISPLAY_MODE, Glu.GLU_FILL);
                                break;
                            default:
                                Glu.gluNurbsProperty(bezSurface, Glu.GLU_DISPLAY_MODE, Glu.GLU_OUTLINE_POLYGON);
                                break;
                        }

                        float[,] outerTrimPts = { { 0.0f, 0.0f }, { 1.0f, 0.0f }, { 1.0f, 1.0f }, { 0.0f, 1.0f }, { 0.0f, 0.0f } };
                        float[,] innerTrimPtsl = { { 0.25f, 0.5f }, { 0.5f, 0.75f }, { 0.75f, 0.5f } };
                        float[,] innerTrimPts2 = { { 0.75f, 0.5f }, { 0.75f, 0.25f }, { 0.25f, 0.25f }, { 0.25f, 0.5f } };
                        float[] surfKnots = { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.0f, 1.0f, 1.0f };
                        float[] trimCurveKnots = { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.0f, 1.0f, 1.0f };

                        Glu.gluBeginSurface(bezSurface);
                        Glu.gluNurbsSurface(bezSurface, 8, surfKnots, 8, surfKnots, 4 * 3, 3, bezArrayData, 4, 4, Gl.GL_MAP2_VERTEX_3);
                        Glu.gluBeginTrim(bezSurface);

                        /* Внешняя обрезающая кривая (против часовой стрелки). */

                        Glu.gluPwlCurve(bezSurface, 5, outerTrimPts, 2, Glu.GLU_MAP1_TRIM_2);
                        Glu.gluEndTrim(bezSurface);
                        Glu.gluBeginTrim(bezSurface);

                        /* Участки внутренней обрезающей кривой * (по часовой стрелке). */

                        Glu.gluPwlCurve(bezSurface, 3, innerTrimPtsl, 2, Glu.GLU_MAP1_TRIM_2);
                        Glu.gluNurbsCurve(bezSurface, 8, trimCurveKnots, 2, innerTrimPts2, 4, Glu.GLU_MAP1_TRIM_2);
                        Glu.gluEndTrim(bezSurface);
                        Glu.gluEndSurface(bezSurface);
                    }
                    break;
            }
        }

        #endregion

        #region Object transformations

        private void Rotate()
        {
            if (checkBoxRotation.Checked)
            {
                _rot1++;
                _rot2++;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxObjectType.SelectedIndex == 2 || comboBoxObjectType.SelectedIndex == 3)
            {
                comboBoxRenderMode.SelectedIndex = 1;
                comboBoxRenderMode.Enabled = false;
            }
            else
                comboBoxRenderMode.Enabled = true;
            ObjectGeometryGenerate();
            ObjectResultGenerate();
        }

        private void ObjectGeometryGenerate()
        {
            switch (comboBoxObjectType.SelectedIndex)
            {
                case 0 when 0.GetType() == typeof(int): // Software torius
                    {
                        // generate ellipse
                        double rad = 5;
                        double smoothess = 0;
                        _elementsCount = trackBarSmooth.Value;
                        for (int ax = 0; ax < trackBarSmooth.Value; ax++)
                        {
                            smoothess = ((double)(trackBarSmooth.Value - ax) / (double)trackBarSmooth.Value) * 2 * Math.PI; // TODO remove PI
                            _geom2x2[ax, 0] = rad * Math.Cos(smoothess); // |cos(theta)|^2/n * rad * sgn cos(theta)
                            _geom2x2[ax, 1] = rad * Math.Sin(smoothess);
                            _geom2x2[ax, 2] = 0;
                        }
                    }
                    break;
                case 1 when 1.GetType() == typeof(int): // Software superellipse
                    {
                        // generate superellipse
                        double rad = 5;
                        double smoothess = 0;
                        double n = trackBarParam.Value * 0.25;
                        _elementsCount = trackBarSmooth.Value;

                        for (int ax = 0; ax < trackBarSmooth.Value; ax++)
                        {
                            smoothess = ((double)(trackBarSmooth.Value - ax) / (double)trackBarSmooth.Value) * 2 * Math.PI; // TODO remove PI
                            _geom2x2[ax, 0] = Math.Pow(Math.Abs(Math.Cos(smoothess)), 2.0 / n) * rad * Math.Sign(Math.Cos(smoothess)); // |cos(theta)|^2/n * rad * sgn cos(theta)
                            _geom2x2[ax, 1] = Math.Pow(Math.Abs(Math.Sin(smoothess)), 2.0 / n) * rad * Math.Sign(Math.Sin(smoothess));
                            _geom2x2[ax, 2] = 0;
                        }
                    }
                    break;
                case 2 when 2.GetType() == typeof(int):
                    // all generate by GLUT; nothing to generate
                    break;
                case 3 when 3.GetType() == typeof(int):
                    // all generate by GLUT; nothing to generate
                    break;
                case 4 when 4.GetType() == typeof(int): // Default (from 1st lab)
                    {
                        _elementsCount = 8;
                        FillGeometricArrayBy4Case();
                    }
                    break;
            }
        }

        private void FillGeometricArrayBy4Case()
        {
            _geom2x2[0, 0] = 0;
            _geom2x2[0, 1] = 0;
            _geom2x2[0, 2] = 0.1;

            _geom2x2[1, 0] = 1;
            _geom2x2[1, 1] = 0;
            _geom2x2[1, 2] = 0;

            _geom2x2[2, 0] = 2;
            _geom2x2[2, 1] = 0;
            _geom2x2[2, 2] = 1;

            _geom2x2[3, 0] = 1;
            _geom2x2[3, 1] = 0;
            _geom2x2[3, 2] = 2;

            _geom2x2[4, 0] = 1;
            _geom2x2[4, 1] = 0;
            _geom2x2[4, 2] = 5;

            _geom2x2[5, 0] = 1.2;
            _geom2x2[5, 1] = 0;
            _geom2x2[5, 2] = 5.1;

            _geom2x2[6, 0] = 1;
            _geom2x2[6, 1] = 0;
            _geom2x2[6, 2] = 6;

            _geom2x2[7, 0] = 0;
            _geom2x2[7, 1] = 0;
            _geom2x2[7, 2] = 6.5;
        }

        private void ObjectResultGenerate()
        {
            switch (comboBoxObjectType.SelectedIndex)
            {
                case 0:
                    {
                        double rad = 2.0 / (trackBarParam.Value / 2.0 + 0.5);  //trackBarParam.Value can me from 1 to 10
                        double radax = (trackBarParam.Value + 5) / 2.0;
                        double fi = 0; // 0 < φ < π
                        double theta = 0; // 0 < θ < 2π
                        _elementsCount = trackBarSmooth.Value;

                        for (int ax = 0; ax < trackBarSmooth.Value; ax++) // count_elements == trackBarSmooth.Value
                        {
                            fi = ((double)(trackBarSmooth.Value - ax) / (double)trackBarSmooth.Value) * 2 * Math.PI - Math.PI;
                            for (int bx = 0; bx < trackBarSmooth.Value; bx++)
                            {
                                theta = ((double)(trackBarSmooth.Value - bx) / (double)trackBarSmooth.Value) * 2 * Math.PI - Math.PI;
                                _resGeometric3x3[ax, bx, 0] = (radax + rad * Math.Cos(fi)) * Math.Cos(theta);
                                _resGeometric3x3[ax, bx, 1] = (radax + rad * Math.Cos(fi)) * Math.Sin(theta);
                                _resGeometric3x3[ax, bx, 2] = rad * Math.Sin(fi);
                            }
                        }
                    }
                    break;
                case 1:
                    {
                        double rad = 5;
                        double fi = 0; // 0 < φ < π
                        double theta = 0; // 0 < θ < 2π
                        double n = trackBarParam.Value * 0.25;
                        _elementsCount = trackBarSmooth.Value;
                        for (int ax = 0; ax < trackBarSmooth.Value; ax++)
                        {
                            fi = ((double)(trackBarSmooth.Value - ax) / (double)trackBarSmooth.Value) * Math.PI - Math.PI / 2;
                            for (int bx = 0; bx < trackBarSmooth.Value; bx++)
                            {
                                theta = ((double)(trackBarSmooth.Value - bx) / (double)trackBarSmooth.Value) * 2 * Math.PI - Math.PI;
                                _resGeometric3x3[ax, bx, 0] = rad * Math.Pow(Math.Abs(Math.Cos(fi)), 2.0 / n) * Math.Sign(Math.Cos(fi)) * Math.Pow(Math.Abs(Math.Cos(theta)), 2.0 / n) * Math.Sign(Math.Cos(theta));
                                _resGeometric3x3[ax, bx, 1] = rad * Math.Pow(Math.Abs(Math.Cos(fi)), 2.0 / n) * Math.Sign(Math.Cos(fi)) * Math.Pow(Math.Abs(Math.Sin(theta)), 2.0 / n) * Math.Sign(Math.Sin(theta));
                                _resGeometric3x3[ax, bx, 2] = rad * Math.Pow(Math.Abs(Math.Sin(fi)), 2.0 / n) * Math.Sign(Math.Sin(fi));
                            }
                        }
                    }
                    break;
                case 2 when 2.GetType() == typeof(int):
                    break;
                case 3 when 3.GetType() == typeof(int):
                    break;
                case 4 when 4.GetType() == typeof(int):
                    double Angle = 2 * Math.PI / trackBarSmooth.Value;
                    for (int ax = 0; ax < _elementsCount; ax++)
                    {
                        for (int bx = 0; bx < trackBarSmooth.Value; bx++)
                        {
                            if (bx > 0)
                                PrevAxesBuilder(Angle, ax, bx);
                            else
                                AxesFirstBuilder(ax, bx);
                        }
                    }
                    break;
            }
        }

        private void PrevAxesBuilder(double Angle, int ax, int bx)
        {
            double new_x = _resGeometric3x3[ax, bx - 1, 0] * Math.Cos(Angle) - _resGeometric3x3[ax, bx - 1, 1] * Math.Sin(Angle);
            double new_y = _resGeometric3x3[ax, bx - 1, 0] * Math.Sin(Angle) + _resGeometric3x3[ax, bx - 1, 1] * Math.Cos(Angle);
            _resGeometric3x3[ax, bx, 0] = new_x;
            _resGeometric3x3[ax, bx, 1] = new_y;
            _resGeometric3x3[ax, bx, 2] = _geom2x2[ax, 2];
        }

        private void AxesFirstBuilder(int ax, int bx)
        {
            double new_x = _geom2x2[ax, 0] * Math.Cos(0) - _geom2x2[ax, 1] * Math.Sin(0);
            double new_y = _geom2x2[ax, 1] * Math.Sin(0) + _geom2x2[ax, 1] * Math.Cos(0);
            _resGeometric3x3[ax, bx, 0] = new_x;
            _resGeometric3x3[ax, bx, 1] = new_y;
            _resGeometric3x3[ax, bx, 2] = _geom2x2[ax, 2];
        }

        #endregion

        #region Events

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://shadowhd.ru/");
        }

        private void TrackBarSmooth_Scroll(object sender, EventArgs e)
        {
            ObjectGeometryGenerate();
            ObjectResultGenerate();
        }

        private void ButtonRotation_MouseDown(object sender, MouseEventArgs e)
        {
            checkBoxRotation.Checked = true;
        }

        private void TrackBarSize_Scroll(object sender, EventArgs e)
        { }

        private void TrackBarParam_Scroll(object sender, EventArgs e)
        {
            ObjectGeometryGenerate();
            ObjectResultGenerate();
        }

        private void ButtonRotation_MouseUp(object sender, MouseEventArgs e)
        {
            checkBoxRotation.Checked = false;
        }

        #endregion

        #region Form

        private void AnT_Load(object sender, EventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGBA | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH | Glut.GLUT_MULTISAMPLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_MULTISAMPLE_ARB);

            float[] light1_diffuse = { 0.4f, 0.7f, 0.2f };
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, light1_diffuse);
            comboBoxObjectType.SelectedIndex = Consts.AppOptions.SELECT_OBJECT;
            comboBoxRenderMode.SelectedIndex = Consts.AppOptions.SELECT_RENDER_MODE;
            comboBoxFigureStyle.SelectedIndex = Consts.AppOptions.SELECT_FIGURE_STYLE;
            ObjectGeometryGenerate();
            ObjectResultGenerate();
            renderTimer.Start();
        }

        #endregion

        #region Start init data

        private double[,,] _bezArr = {

        { {-1.5, -1.5, 4.0}, {-0.5,  -1.5, 2.0},

        {-0.5, -1.5, -1.0}, { 1.5, -1.5, 2.0} },

        { {-1.5, -0.5, 1.0}, {-0.5,  -0.5, 3.0},

        { 0.5, -0.5, 0.0}, { 1.5, -0.5, -1.0} },

        { {-1.5, 0.5, 4.0}, {-0.5, 0.5, 0.0},

        { 0.5, 0.5, 3.0}, { 1.5, 0.5, 4.0} },

        { {-1.5, 1.5, -2.0}, {-0.5,  1.5, -2.0},

        { 0.5, 1.5, 0.0}, { 1.5, 1.5, -1.0 } }
        };

        private float[,,] bezArrayData =
            {
        { {-1.5f, -1.5f,  4.0f}, {-0.5f, -1.5f, 2.0f},
        {  -0.5f, -1.5f, -1.0f}, { 1.5f, -1.5f, 2.0f} },
        { {-1.5f, -0.5f,  1.0f}, {-0.5f, -0.5f, 3.0f},
        {   0.5f, -0.5f,  0.0f}, { 1.5f, -0.5f, -1.0f} },
        { {-1.5f,  0.5f,  4.0f}, {-0.5f, 0.5f, 0.0f},
        {   0.5f,  0.5f,  3.0f}, { 1.5f, 0.5f, 4.0f} },
        { {-1.5f,  1.5f, -2.0f}, {-0.5f, 1.5f, -2.0f},
        {   0.5f,  1.5f,  0.0f}, { 1.5f, 1.5f, -1.0f } }
        };


        #endregion

    }
}
