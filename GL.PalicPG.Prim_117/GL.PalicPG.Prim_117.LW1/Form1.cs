using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace GL.PalicPG.Prim_117.LW1
{
    public partial class Form1 : Form
    {

        private float rot_1, rot_2;
        private double[,] GeometricArray = new double[64, 3];
        private double[,,] ResaultGeometric = new double[64, 64, 3];
        private int count_elements = 0;
        private double Angle = 2 * Math.PI / 64;
        private int Iter = 64;
        private short _a => 2;
        private short _b => 8;
        private short _n => 20;

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            // вызываем функцию, отвечающей за отрисовку сцены
            Draw();
        }

        private void Draw()
        {
            // два параметра, которые мы будем использовать для непрерывного вращения сцены вокруг 2 координатных осей
            rot_1++;
            rot_2++;

            // очистка буфера цвета и буфера глубины 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            // очищение текущей матрицы 
            Gl.glLoadIdentity();

            // установка положения камеры (наблюдателя). Как видно из кода
            // дополнительно на полложение наблюдателя по оси Z влияет значение
            // установленное в ползунке, доступном для пользователя.

            // таким образом, при перемещении ползунка, наблюдатель будет  отдалятся или приближатся к объекту наблюдения
            Gl.glTranslated(0, 0, -7 - trackBar1.Value);
            // 2 поворота (углы rot_1 и rot_2)
            Gl.glRotated(rot_1, 1, 0, 0);
            Gl.glRotated(rot_2, 0, 1, 0);

            // устанавливаем размер точек равный 5
            Gl.glPointSize(5.0f);

            // условие switch определяет установленный режим отображения, на основе выбранного пункта элемента
            // comboBox, установленного в форме программы
            switch (comboBox1.SelectedIndex)
            {
                case 0: // отображение в виде точек
                    {
                        // режим вывода геометрии - точки
                        Gl.glBegin(Gl.GL_POINTS);

                        // выводим всю ранее просчитанную геометрию объекта
                        for (int ax = 0; ax < count_elements; ax++)
                        {
                            for (int bx = 0; bx < Iter; bx++)
                            {
                                // отрисовка точки
                                Gl.glVertex3d(ResaultGeometric[ax, bx, 0], ResaultGeometric[ax, bx, 1], ResaultGeometric[ax, bx, 2]);
                            }
                        }
                        // завершаем режим рисования
                        Gl.glEnd();

                        break;

                    }
                case 1: // отображение объекта в сеточном режиме, используя режим GL_LINES_STRIP
                    {
                        // устанавливаем режим отрисвки линиями (последовательность линий)
                        Gl.glBegin(Gl.GL_LINE_STRIP);
                        for (int ax = 0; ax < count_elements; ax++)
                        {
                            for (int bx = 0; bx < Iter; bx++)
                            {
                                Gl.glVertex3d(ResaultGeometric[ax, bx, 0], ResaultGeometric[ax, bx, 1], ResaultGeometric[ax, bx, 2]);
                                Gl.glVertex3d(ResaultGeometric[ax + 1, bx, 0], ResaultGeometric[ax + 1, bx, 1], ResaultGeometric[ax + 1, bx, 2]);
                                if (bx + 1 < Iter - 1)
                                    Gl.glVertex3d(ResaultGeometric[ax + 1, bx + 1, 0], ResaultGeometric[ax + 1, bx + 1, 1], ResaultGeometric[ax + 1, bx + 1, 2]);
                                else
                                    Gl.glVertex3d(ResaultGeometric[ax + 1, 0, 0], ResaultGeometric[ax + 1, 0, 1], ResaultGeometric[ax + 1, 0, 2]);
                            }
                        }
                        Gl.glEnd();
                        break;
                    }
                case 2: // отрисовка оболочки с расчетом нормалей для корректного затенения граней объекта
                    {
                        Gl.glBegin(Gl.GL_QUADS); // режим отрисовки полигонов состоящих из 4 вершин
                        for (int ax = 0; ax < count_elements; ax++)
                        {
                            for (int bx = 0; bx < Iter; bx++)
                            {
                                // вспомогательные переменные, для более наглядного использования кода при расчете нормалей
                                double x1 = 0, x2 = 0, x3 = 0, x4 = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0, z1 = 0, z2 = 0, z3 = 0, z4 = 0;

                                // первая вершина
                                x1 = ResaultGeometric[ax, bx, 0];
                                y1 = ResaultGeometric[ax, bx, 1];
                                z1 = ResaultGeometric[ax, bx, 2];


                                if (ax + 1 < count_elements) // если текущий ax не последний
                                {
                                    // берем следующую точку последовательности
                                    x2 = ResaultGeometric[ax + 1, bx, 0];
                                    y2 = ResaultGeometric[ax + 1, bx, 1];
                                    z2 = ResaultGeometric[ax + 1, bx, 2];

                                    if (bx + 1 < Iter - 1) // если текущий bx не последний
                                    {
                                        // берем следующую точку последовательности и следующий медивн
                                        x3 = ResaultGeometric[ax + 1, bx + 1, 0];
                                        y3 = ResaultGeometric[ax + 1, bx + 1, 1];
                                        z3 = ResaultGeometric[ax + 1, bx + 1, 2];

                                        // точка соотвествующуя по номеру , только на соседнем медиане
                                        x4 = ResaultGeometric[ax, bx + 1, 0];
                                        y4 = ResaultGeometric[ax, bx + 1, 1];
                                        z4 = ResaultGeometric[ax, bx + 1, 2];
                                    }
                                    else
                                    {
                                        // если это последний медиан - то в качесвте след. мы берем начальный (замыкаем геометрию фигуры)
                                        x3 = ResaultGeometric[ax + 1, 0, 0];
                                        y3 = ResaultGeometric[ax + 1, 0, 1];
                                        z3 = ResaultGeometric[ax + 1, 0, 2];

                                        x4 = ResaultGeometric[ax, 0, 0];
                                        y4 = ResaultGeometric[ax, 0, 1];
                                        z4 = ResaultGeometric[ax, 0, 2];
                                    }
                                }
                                else // данный элемент ax последний, следовательно мы будем использовать начальный (нулевой) вместо данного ax
                                {
                                    // слудуещей точкой будет нулевая ax
                                    x2 = ResaultGeometric[0, bx, 0];
                                    y2 = ResaultGeometric[0, bx, 1];
                                    z2 = ResaultGeometric[0, bx, 2];

                                    if (bx + 1 < Iter - 1)
                                    {
                                        x3 = ResaultGeometric[0, bx + 1, 0];
                                        y3 = ResaultGeometric[0, bx + 1, 1];
                                        z3 = ResaultGeometric[0, bx + 1, 2];

                                        x4 = ResaultGeometric[ax, bx + 1, 0];
                                        y4 = ResaultGeometric[ax, bx + 1, 1];
                                        z4 = ResaultGeometric[ax, bx + 1, 2];
                                    }
                                    else
                                    {
                                        x3 = ResaultGeometric[0, 0, 0];
                                        y3 = ResaultGeometric[0, 0, 1];
                                        z3 = ResaultGeometric[0, 0, 2];

                                        x4 = ResaultGeometric[ax, 0, 0];
                                        y4 = ResaultGeometric[ax, 0, 1];
                                        z4 = ResaultGeometric[ax, 0, 2];
                                    }
                                }
                                // переменные для расчета нормал
                                double n1 = 0, n2 = 0, n3 = 0;
                                // нормаль будем расчитывать как векторное произведение граней полигона
                                // для нулевого элемента нормаль мы будем считать немного по другому.

                                // на самом деле разница в расчете нормали актуальна только для 1 и последнего и первого полигона на медиане

                                if (ax == 0) // при расчете нормали для ax мы будем использовать точки 1,2,3
                                {
                                    n1 = (y2 - y1) * (z3 - z1) - (y3 - y1) * (z2 - z1);
                                    n2 = (z2 - z1) * (x3 - x1) - (z3 - z1) * (x2 - x1);
                                    n3 = (x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1);
                                }
                                else // для остальных - 1,3,4
                                {
                                    n1 = (y4 - y3) * (z1 - z3) - (y1 - y3) * (z4 - z3);
                                    n2 = (z4 - z3) * (x1 - x3) - (z1 - z3) * (x4 - x3);
                                    n3 = (x4 - x3) * (y1 - y3) - (x1 - x3) * (y4 - y3);
                                }
                                // если не включен режим GL_NORMILIZE то мы должны в обязательном порядке 
                                // произвести нормализацию вектора нормали, перед тем как передать информацию о нормали  
                                double n5 = (double)Math.Sqrt(n1 * n1 + n2 * n2 + n3 * n3);
                                n1 /= (n5 + 0.01);
                                n2 /= (n5 + 0.01);
                                n3 /= (n5 + 0.01);

                                // передаем информацию о нормали
                                Gl.glNormal3d(-n1, -n2, -n3);

                                // передаем 4 вершины для отрисовки полигона
                                Gl.glVertex3d(x1, y1, z1);
                                Gl.glVertex3d(x2, y2, z2);
                                Gl.glVertex3d(x3, y3, z3);
                                Gl.glVertex3d(x4, y4, z4);
                            }
                        }
                        // завершаем выбранный режим рисования полигонов
                        Gl.glEnd();
                        break;
                    }
            }

            // возвращаем сохраненную матрицу
            Gl.glPopMatrix();

            // завершаем рисование
            Gl.glFlush();

            // обновляем элемент AnT
            AnT.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // инициализация Glut 
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // очитка окна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соотвествии с размерами элемента anT 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);


            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            count_elements = _n;
            double xi = default(double);
            float h = (float)(_b - _a) / _n;

            for (int _ = 0; _ < _n; _++)
            {
                xi = _a + _ * h;
                GeometricArray[_, 0] = xi;
                GeometricArray[_, 1] = 0;
                GeometricArray[_, 2] = Math.Sqrt(Math.Pow(xi - 5, 4) + 1);
            }

            // по умолчанию мы будем  отрисовывать фигуру в режиме GL_POINTS 
            comboBox1.SelectedIndex = 0;

            // построение геометрии тела вращения
            // принцип сводится к 2м цилкам - на основе первого перебираются 
            // вершины в геометрической последовательности
            // второй использую параметр Iter производит поворот последней линии геометрии вокруг центра тела вращения
            // при этом используется заранее определенный угол angle который определяется как 2*Pi / количество медиан объекта
            // за счет выполнения этого алгоритма получается набор вершин описывающих оболочку тела врещения.
            // остается только соединить эти точки в режиме рисования примитивов для получения 
            // визуализированного объекта

            // цикл по последовательности точек кривой, на основе которой будет построено тело вращения
            for (int ax = 0; ax < count_elements; ax++)
            {
                // цикла по медианам объекта, заранее определенным в программе
                for (int bx = 0; bx < Iter; bx++)
                {
                    // для всех (bx > 0) элементов алгоритма используются предыдушая построенная последовательность
                    // для ее поворота на установленный угол
                    if (bx > 0)
                    {
                        double new_x = ResaultGeometric[ax, bx - 1, 0] * Math.Cos(Angle) - ResaultGeometric[ax, bx - 1, 1] * Math.Sin(Angle);
                        double new_y = ResaultGeometric[ax, bx - 1, 0] * Math.Sin(Angle) + ResaultGeometric[ax, bx - 1, 1] * Math.Cos(Angle);
                        ResaultGeometric[ax, bx, 0] = new_x;
                        ResaultGeometric[ax, bx, 1] = new_y;
                        ResaultGeometric[ax, bx, 2] = GeometricArray[ax, 2];
                    }
                    else // для построения первой мидианы мы используем начальную кривую, описывая ее нулевым значением угла поворота
                    {
                        double new_x = GeometricArray[ax, 0] * Math.Cos(0) - GeometricArray[ax, 1] * Math.Sin(0);
                        double new_y = GeometricArray[ax, 1] * Math.Sin(0) + GeometricArray[ax, 1] * Math.Cos(0);
                        ResaultGeometric[ax, bx, 0] = new_x;
                        ResaultGeometric[ax, bx, 1] = new_y;
                        ResaultGeometric[ax, bx, 2] = GeometricArray[ax, 2];
                    }

                }
            }
            // активация таймера
            RenderTimer.Start();
        }

        private void AnT_Load(object sender, EventArgs e)
        { }
    }
}
