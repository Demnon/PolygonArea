using System;
using System.Windows.Forms;

namespace PolygonArea
{
    public partial class MainForm : Form
    {
        // Вторичный поток, в котором вычисляется площадь
        CalculateArea c_Area;

        public MainForm()
        {
            InitializeComponent();
            c_Area = null;
        }

        // Добавление введенного пользователем количества строк в таблицу (координат углов)
        private void t_PolygonAngles_TextChanged(object sender, EventArgs e)
        {
            d_Table.Rows.Clear();
            t_PolygonArea.Text = "";
            try
            {
                if (t_PolygonAngles.Text != null && t_PolygonAngles.Text != "")
                {
                    int i_CountAngles = Convert.ToInt32(t_PolygonAngles.Text);
                    if (i_CountAngles<1 || i_CountAngles>1000)
                    {
                        MessageBox.Show("Введите корректное количество углов (не более 1000).");
                        return;
                    }

                    d_Table.Rows.Add(i_CountAngles);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Введите корректное количество углов (не более 1000).");
            }
        }

        // Расчитать площадь
        private void b_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Если поток вычисления не запущен
                if (c_Area == null || (c_Area != null && !c_Area.GetRun))
                {
                    t_PolygonArea.Text = "";
                    // Считывание координат в двумерный массив
                    double[,] d_Coordinates = new double[d_Table.Rows.Count, 2];
                    Table.GetCoordinates(d_Table, d_Coordinates);

                    c_Area = new CalculateArea(d_Coordinates, t_PolygonArea);
                    c_Area.RunCalculateArea();
                }
            }
            catch (ApplicationException e_Ex)
            {
                MessageBox.Show(e_Ex.Message);
            }
        }

        // Закрытие приложения
        private void b_Exit_Click(object sender, EventArgs e)
        {
            if (c_Area != null)
            {
                if (c_Area.GetRun)
                {
                    c_Area.StopCalculateArea();
                }
                c_Area = null;
            }
            Close();
        }

        // Загрузка данных из файла 
        private void b_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog o_Path = new OpenFileDialog();
            o_Path.Multiselect = false;
            o_Path.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            o_Path.FileName = AppDomain.CurrentDomain.BaseDirectory + "Coordinates.txt";
            if (o_Path.ShowDialog()== DialogResult.OK)
            {
                t_PathData.Text = o_Path.FileName;
                FileData.GetData(d_Table, t_PolygonAngles, o_Path.FileName);
            }
        }
    }
}
