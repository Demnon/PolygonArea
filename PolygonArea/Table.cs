using System;
using System.Windows.Forms;

namespace PolygonArea
{
    // Работа с таблицей
    public static class Table
    {
        // Считывание координат из таблицы
        public static void GetCoordinates(DataGridView d_Table, double[,] d_Coordinates)
        {  
            // Считывание координат в двумерные массивы (один для проверки на вершины с одинаковыми координатами, другой для вычисления площади)
            for (int i = 0; i < d_Table.Rows.Count; i++)
            {
                double d_ValueX = 0;
                if (d_Table.Rows[i].Cells[0].Value == null || d_Table.Rows[i].Cells[0].Value.ToString() == "")
                {
                    throw new ApplicationException("В строке " + (i + 1).ToString() + " столбца 1 пустое значение.");
                }
                if (!double.TryParse(d_Table.Rows[i].Cells[0].Value.ToString(), out d_ValueX))
                {
                    throw new ApplicationException("Неверный формат координаты в строке " + (i + 1).ToString() + "столбца 1.");
                }
                double d_ValueY = 0;
                if (d_Table.Rows[i].Cells[0].Value == null || d_Table.Rows[i].Cells[1].Value.ToString() == "")
                {
                    throw new ApplicationException("В строке " + (i + 1).ToString() + " столбца 2 пустое значение.");
                }
                if (!double.TryParse(d_Table.Rows[i].Cells[1].Value.ToString(), out d_ValueY))
                {
                    throw new ApplicationException("Неверный формат координаты в строке " + (i + 1).ToString() + "столбца 2.");
                }

                d_Coordinates[i, 0] = d_ValueX;
                d_Coordinates[i, 1] = d_ValueY;
            }
        }
    }
}
