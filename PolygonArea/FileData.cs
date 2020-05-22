using System;
using System.IO;
using System.Windows.Forms;

namespace PolygonArea
{
    // Получение данных из файла и вывод в таблицу
    public static class FileData
    {
        public static void GetData(DataGridView d_Table, TextBox t_PolygonAngles, string s_PathFile)
        {
            t_PolygonAngles.Text = "";
            // Открытие файла и получение информации оттуда
            string[] s_Lines = null; ;
            using (StreamReader s_Reader = new StreamReader(s_PathFile))
            {
                string[] separator = { Environment.NewLine };
                s_Lines = s_Reader.ReadToEnd().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            }
            t_PolygonAngles.Text = s_Lines.Length.ToString();
            for (int i=0;i<s_Lines.Length;i++)
            {
                d_Table[0, i].Value = s_Lines[i].Split(' ')[0];
                d_Table[1, i].Value = s_Lines[i].Split(' ')[1];
            }
        }
    }
}
