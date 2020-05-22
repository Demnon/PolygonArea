using System;
using System.Windows.Forms;
using System.Threading;

namespace PolygonArea
{
    // Вычисление площади
    public class CalculateArea
    {
        // Поле вывода площади
        TextBox t_Area;
        // Поток
        Thread t_Thread;
        // Поток запущен
        bool b_Run;
        // Массив данных
        double[,] d_Coordinates;

        public CalculateArea(double[,] d_Coordinates, TextBox t_Area)
        {
            this.t_Area = t_Area;
            this.d_Coordinates = d_Coordinates;
            b_Run = false;
            t_Thread = null;
        }

        public bool GetRun
        {
            get { return b_Run; }
        }

        // Запуск потока вычисления площади
        public void RunCalculateArea()
        {
            t_Thread = new Thread(GetArea);
            t_Thread.Start();
            b_Run = true;
        }

        // Остановка потока вычисления (при закрытии приложения)
        public void StopCalculateArea()
        {
            if (t_Thread != null)
            {
                t_Thread.Abort();
            }
            b_Run = false;
        }

        // Главный метод, который запускается во вторичном потоке
        private void GetArea()
        {
            try
            {
                // Проверка на одинаковые координаты
                TestOnEqualCoordinates();

                // Проверка на пересекающиеся стороны многоугольника
                TestOnIntersectingSides();

                // Вычисление самой площади по формуле Гаусса
                double d_Area = 0;
                for (int i = 0; i < d_Coordinates.GetUpperBound(0) + 1; i++)
                {
                    if (i != d_Coordinates.GetUpperBound(0))
                    {
                        d_Area += d_Coordinates[i, 0] * d_Coordinates[i + 1, 1] - d_Coordinates[i, 1] * d_Coordinates[i + 1, 0];
                    }
                    else
                    {
                        d_Area += d_Coordinates[i, 0] * d_Coordinates[0, 1] - d_Coordinates[i, 1] * d_Coordinates[0, 0];
                    }
                }
                // Вывод на форму в родительском потоке (в котором создан данный textBox)
                t_Area.Invoke((Action)delegate
                {
                    t_Area.Text = (0.5 * Math.Abs(d_Area)).ToString();
                }
                );      
            }
            catch (ApplicationException e_Ex)
            {
                MessageBox.Show(e_Ex.Message);
            }
            b_Run = false;
        }

        // Проверка на одинаковые координаты
        private void TestOnEqualCoordinates()
        {
            for (int i=0;i<d_Coordinates.GetUpperBound(0)+1;i++)
            {
                for (int j=i+1; j<d_Coordinates.GetUpperBound(0) + 1; j++)
                {
                    if (d_Coordinates[i,0] == d_Coordinates[j,0] && d_Coordinates[i,1] == d_Coordinates[j,1])
                    {
                        throw new ApplicationException("Координаты вершин не должны совпадать.");
                    }
                }
            }
        }

        // Проверка на пересекающиеся стороны многоугольника
        private void TestOnIntersectingSides()
        {
            for (int i = 0; i < d_Coordinates.GetUpperBound(0) - 1; i++)
            {
                // Главный вектор 1
                double d_MainVector1X = d_Coordinates[i + 1, 0] - d_Coordinates[i, 0];
                double d_MainVector1Y = d_Coordinates[i + 1, 1] - d_Coordinates[i, 1];
                for (int j = i + 2; j < d_Coordinates.GetUpperBound(0)+1; j++)
                {
                    if (j != d_Coordinates.GetUpperBound(0))
                    {
                        CalculateVectorMultiplies(i, j, j + 1, d_MainVector1X, d_MainVector1Y);                     
                    }
                    else
                    {
                        CalculateVectorMultiplies(i, j, 0, d_MainVector1X, d_MainVector1Y);       
                    }
                }
            }
        }

        // Вспомогательный метод для расчета векторных произведений
        private void CalculateVectorMultiplies(int i, int j, int k, double d_MainVector1X, double d_MainVector1Y)
        {
            // Вычисление векторных произведений, если дает равные знаки, то отрезки не пересекаются
            // Главный вектор 2
            double d_MainVector2X = d_Coordinates[k, 0] - d_Coordinates[j, 0];
            double d_MainVector2Y = d_Coordinates[k, 1] - d_Coordinates[j, 1];
            // Вектор 1
            double d_Vector1X = d_Coordinates[k, 0] - d_Coordinates[i, 0];
            double d_Vector1Y = d_Coordinates[k, 1] - d_Coordinates[i, 1];
            // Вектор 2
            double d_Vector2X = d_Coordinates[j, 0] - d_Coordinates[i, 0];
            double d_Vector2Y = d_Coordinates[j, 1] - d_Coordinates[i, 1];
            // Вектор 3
            double d_Vector3X = d_Coordinates[i, 0] - d_Coordinates[j, 0];
            double d_Vector3Y = d_Coordinates[i, 1] - d_Coordinates[j, 1];
            // Вектор 4
            double d_Vector4X = d_Coordinates[i + 1, 0] - d_Coordinates[j, 0];
            double d_Vector4Y = d_Coordinates[i + 1, 1] - d_Coordinates[j, 1];
            // 1 векторное произведение
            double d_Multiply1 = d_MainVector1X * d_Vector1Y - d_MainVector1Y * d_Vector1X;
            // 2 векторное произвдение 
            double d_Multiply2 = d_MainVector1X * d_Vector2Y - d_MainVector1Y * d_Vector2X;
            // 3 векторное произведение
            double d_Multiply3 = d_MainVector2X * d_Vector3Y - d_MainVector2Y * d_Vector3X;
            // 4 векторное произведение
            double d_Multiply4 = d_MainVector2X * d_Vector4Y - d_MainVector2Y * d_Vector4X;

            if (d_Multiply1 * d_Multiply2 < 0 && d_Multiply3 * d_Multiply4 < 0)
            {
                throw new ApplicationException(string.Format("Введите простой многоугольник (с непересекающимися сторонами), " +
                "сторона c координатами X = {0} и Y = {1}; X = {2} и Y = {3} пересекается со стороной " +
                "с координатами X = {4} и Y = {5}; X = {6} и Y = {7}.", d_Coordinates[i, 0], d_Coordinates[i, 1],
                    d_Coordinates[i + 1, 0], d_Coordinates[i + 1, 1], d_Coordinates[j, 0], d_Coordinates[j, 1],
                    d_Coordinates[k, 0], d_Coordinates[k, 1]));
            }
        }
    }
}
