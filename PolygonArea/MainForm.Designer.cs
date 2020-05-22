namespace PolygonArea
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.t_PolygonArea = new System.Windows.Forms.TextBox();
            this.b_Calculate = new System.Windows.Forms.Button();
            this.d_Table = new System.Windows.Forms.DataGridView();
            this.c_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.t_PolygonAngles = new System.Windows.Forms.TextBox();
            this.l_PolygonAngles = new System.Windows.Forms.Label();
            this.b_Exit = new System.Windows.Forms.Button();
            this.toolTipInfoAboutPolygon = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.t_PathData = new System.Windows.Forms.TextBox();
            this.b_Select = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_Table)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.d_Table, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_Exit, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.54023F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.80843F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.32567F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.94253F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.t_PolygonArea, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.b_Calculate, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 184);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(689, 34);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // t_PolygonArea
            // 
            this.t_PolygonArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_PolygonArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.t_PolygonArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_PolygonArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_PolygonArea.Location = new System.Drawing.Point(450, 4);
            this.t_PolygonArea.Name = "t_PolygonArea";
            this.t_PolygonArea.ReadOnly = true;
            this.t_PolygonArea.Size = new System.Drawing.Size(132, 26);
            this.t_PolygonArea.TabIndex = 14;
            this.t_PolygonArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipInfoAboutPolygon.SetToolTip(this.t_PolygonArea, "Вводите последовательно координаты X и Y вершин многоугольника,");
            // 
            // b_Calculate
            // 
            this.b_Calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.b_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Calculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Calculate.ForeColor = System.Drawing.Color.White;
            this.b_Calculate.Location = new System.Drawing.Point(122, 4);
            this.b_Calculate.Name = "b_Calculate";
            this.b_Calculate.Size = new System.Drawing.Size(100, 26);
            this.b_Calculate.TabIndex = 16;
            this.b_Calculate.Text = "Рассчитать";
            this.b_Calculate.UseVisualStyleBackColor = false;
            this.b_Calculate.Click += new System.EventHandler(this.b_Calculate_Click);
            // 
            // d_Table
            // 
            this.d_Table.AllowUserToAddRows = false;
            this.d_Table.AllowUserToDeleteRows = false;
            this.d_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.d_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.d_Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.d_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.d_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_X,
            this.с_Y});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_Table.DefaultCellStyle = dataGridViewCellStyle6;
            this.d_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d_Table.EnableHeadersVisualStyles = false;
            this.d_Table.Location = new System.Drawing.Point(3, 54);
            this.d_Table.Name = "d_Table";
            this.d_Table.RowHeadersVisible = false;
            this.d_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.d_Table.ShowCellToolTips = false;
            this.d_Table.Size = new System.Drawing.Size(689, 124);
            this.d_Table.TabIndex = 4;
            this.toolTipInfoAboutPolygon.SetToolTip(this.d_Table, resources.GetString("d_Table.ToolTip"));
            // 
            // c_X
            // 
            this.c_X.HeaderText = "X";
            this.c_X.Name = "c_X";
            // 
            // с_Y
            // 
            this.с_Y.HeaderText = "Y";
            this.с_Y.Name = "с_Y";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.84761F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.143686F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.77068F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.224964F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.t_PolygonAngles, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.l_PolygonAngles, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.t_PathData, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.b_Select, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(689, 45);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // t_PolygonAngles
            // 
            this.t_PolygonAngles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_PolygonAngles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.t_PolygonAngles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_PolygonAngles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_PolygonAngles.Location = new System.Drawing.Point(312, 9);
            this.t_PolygonAngles.Name = "t_PolygonAngles";
            this.t_PolygonAngles.Size = new System.Drawing.Size(57, 26);
            this.t_PolygonAngles.TabIndex = 13;
            this.t_PolygonAngles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_PolygonAngles.TextChanged += new System.EventHandler(this.t_PolygonAngles_TextChanged);
            // 
            // l_PolygonAngles
            // 
            this.l_PolygonAngles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_PolygonAngles.AutoSize = true;
            this.l_PolygonAngles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_PolygonAngles.Location = new System.Drawing.Point(4, 13);
            this.l_PolygonAngles.Name = "l_PolygonAngles";
            this.l_PolygonAngles.Size = new System.Drawing.Size(300, 19);
            this.l_PolygonAngles.TabIndex = 12;
            this.l_PolygonAngles.Text = "Введите количество углов многоугольника:";
            this.l_PolygonAngles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_Exit
            // 
            this.b_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.b_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Exit.ForeColor = System.Drawing.Color.White;
            this.b_Exit.Location = new System.Drawing.Point(588, 228);
            this.b_Exit.Margin = new System.Windows.Forms.Padding(3, 3, 7, 7);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(100, 26);
            this.b_Exit.TabIndex = 15;
            this.b_Exit.Text = "Выход";
            this.b_Exit.UseVisualStyleBackColor = false;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // toolTipInfoAboutPolygon
            // 
            this.toolTipInfoAboutPolygon.AutomaticDelay = 100;
            this.toolTipInfoAboutPolygon.AutoPopDelay = 10000;
            this.toolTipInfoAboutPolygon.InitialDelay = 100;
            this.toolTipInfoAboutPolygon.ReshowDelay = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(375, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Либо выберите файл с данными:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_PathData
            // 
            this.t_PathData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_PathData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.t_PathData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_PathData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_PathData.Location = new System.Drawing.Point(505, 9);
            this.t_PathData.Name = "t_PathData";
            this.t_PathData.ReadOnly = true;
            this.t_PathData.Size = new System.Drawing.Size(144, 26);
            this.t_PathData.TabIndex = 15;
            this.t_PathData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_Select
            // 
            this.b_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.b_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Select.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Select.Location = new System.Drawing.Point(655, 9);
            this.b_Select.Name = "b_Select";
            this.b_Select.Size = new System.Drawing.Size(31, 26);
            this.b_Select.TabIndex = 16;
            this.b_Select.Text = "...";
            this.b_Select.UseVisualStyleBackColor = false;
            this.b_Select.Click += new System.EventHandler(this.b_Select_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Площадь многоугольника";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_Table)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView d_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn с_Y;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox t_PolygonAngles;
        private System.Windows.Forms.Label l_PolygonAngles;
        private System.Windows.Forms.Button b_Exit;
        private System.Windows.Forms.TextBox t_PolygonArea;
        private System.Windows.Forms.Button b_Calculate;
        private System.Windows.Forms.ToolTip toolTipInfoAboutPolygon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_PathData;
        private System.Windows.Forms.Button b_Select;
    }
}

