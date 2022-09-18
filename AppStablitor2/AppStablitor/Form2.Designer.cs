
namespace AppStablitor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-5D, "2,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "3,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, "4,0,0");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphStabl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btStabl = new System.Windows.Forms.Button();
            this.tmStart = new System.Windows.Forms.Timer(this.components);
            this.gpLeft = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmy1 = new System.Windows.Forms.NumericUpDown();
            this.nmx1 = new System.Windows.Forms.NumericUpDown();
            this.tb1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstStat = new System.Windows.Forms.ListBox();
            this.lbStat = new System.Windows.Forms.Label();
            this.BtClearAll = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.gpOtklon = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nmMaxy2 = new System.Windows.Forms.NumericUpDown();
            this.nmMiny2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nmMaxy1 = new System.Windows.Forms.NumericUpDown();
            this.nmMiny1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nmMaxx2 = new System.Windows.Forms.NumericUpDown();
            this.nmMinx2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nmMaxx1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmMinx1 = new System.Windows.Forms.NumericUpDown();
            this.btClear = new System.Windows.Forms.Button();
            this.btAddList = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.graphStart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.lstArhiv = new System.Windows.Forms.ListBox();
            this.mpPick = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.graphStabl)).BeginInit();
            this.gpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmx1)).BeginInit();
            this.tb1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpOtklon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiny2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiny1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinx1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphStart)).BeginInit();
            this.SuspendLayout();
            // 
            // graphStabl
            // 
            chartArea1.AxisX.Maximum = 5D;
            chartArea1.AxisX.Minimum = -5D;
            chartArea1.AxisX2.Maximum = 5D;
            chartArea1.AxisX2.Minimum = -5D;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = -5D;
            chartArea1.AxisY2.Maximum = 5D;
            chartArea1.AxisY2.Minimum = -5D;
            chartArea1.BorderColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.graphStabl.ChartAreas.Add(chartArea1);
            this.graphStabl.Location = new System.Drawing.Point(271, 93);
            this.graphStabl.Name = "graphStabl";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.CustomProperties = "IsXAxisQuantitative=False";
            series1.IsVisibleInLegend = false;
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 3;
            this.graphStabl.Series.Add(series1);
            this.graphStabl.Size = new System.Drawing.Size(532, 313);
            this.graphStabl.TabIndex = 0;
            this.graphStabl.Text = "graphStabl";
            // 
            // btStabl
            // 
            this.btStabl.Location = new System.Drawing.Point(270, 6);
            this.btStabl.Name = "btStabl";
            this.btStabl.Size = new System.Drawing.Size(127, 23);
            this.btStabl.TabIndex = 1;
            this.btStabl.Text = "Запустить эмуляцию";
            this.btStabl.UseVisualStyleBackColor = true;
            this.btStabl.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmStart
            // 
            this.tmStart.Tick += new System.EventHandler(this.tmStart_Tick);
            // 
            // gpLeft
            // 
            this.gpLeft.Controls.Add(this.label3);
            this.gpLeft.Controls.Add(this.label2);
            this.gpLeft.Controls.Add(this.label1);
            this.gpLeft.Controls.Add(this.nmy1);
            this.gpLeft.Controls.Add(this.nmx1);
            this.gpLeft.ForeColor = System.Drawing.Color.Blue;
            this.gpLeft.Location = new System.Drawing.Point(270, 35);
            this.gpLeft.Name = "gpLeft";
            this.gpLeft.Size = new System.Drawing.Size(530, 52);
            this.gpLeft.TabIndex = 3;
            this.gpLeft.TabStop = false;
            this.gpLeft.Text = "Центр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Эмуляция откл.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // nmy1
            // 
            this.nmy1.DecimalPlaces = 2;
            this.nmy1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmy1.Location = new System.Drawing.Point(198, 19);
            this.nmy1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmy1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmy1.Name = "nmy1";
            this.nmy1.Size = new System.Drawing.Size(49, 20);
            this.nmy1.TabIndex = 2;
            // 
            // nmx1
            // 
            this.nmx1.DecimalPlaces = 2;
            this.nmx1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmx1.Location = new System.Drawing.Point(123, 19);
            this.nmx1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmx1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmx1.Name = "nmx1";
            this.nmx1.Size = new System.Drawing.Size(49, 20);
            this.nmx1.TabIndex = 1;
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.tabPage1);
            this.tb1.Controls.Add(this.tabPage2);
            this.tb1.Location = new System.Drawing.Point(3, 3);
            this.tb1.Name = "tb1";
            this.tb1.SelectedIndex = 0;
            this.tb1.Size = new System.Drawing.Size(817, 525);
            this.tb1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstStat);
            this.tabPage1.Controls.Add(this.lbStat);
            this.tabPage1.Controls.Add(this.BtClearAll);
            this.tabPage1.Controls.Add(this.btSave);
            this.tabPage1.Controls.Add(this.gpOtklon);
            this.tabPage1.Controls.Add(this.graphStabl);
            this.tabPage1.Controls.Add(this.btClear);
            this.tabPage1.Controls.Add(this.btAddList);
            this.tabPage1.Controls.Add(this.btReset);
            this.tabPage1.Controls.Add(this.lstData);
            this.tabPage1.Controls.Add(this.gpLeft);
            this.tabPage1.Controls.Add(this.btStabl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Экран";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstStat
            // 
            this.lstStat.FormattingEnabled = true;
            this.lstStat.HorizontalScrollbar = true;
            this.lstStat.Location = new System.Drawing.Point(11, 413);
            this.lstStat.Name = "lstStat";
            this.lstStat.ScrollAlwaysVisible = true;
            this.lstStat.Size = new System.Drawing.Size(694, 82);
            this.lstStat.TabIndex = 17;
            // 
            // lbStat
            // 
            this.lbStat.AutoSize = true;
            this.lbStat.Location = new System.Drawing.Point(541, 11);
            this.lbStat.Name = "lbStat";
            this.lbStat.Size = new System.Drawing.Size(82, 13);
            this.lbStat.TabIndex = 16;
            this.lbStat.Text = "Рекомендации";
            // 
            // BtClearAll
            // 
            this.BtClearAll.Location = new System.Drawing.Point(714, 472);
            this.BtClearAll.Name = "BtClearAll";
            this.BtClearAll.Size = new System.Drawing.Size(86, 23);
            this.BtClearAll.TabIndex = 15;
            this.BtClearAll.Text = "Очистить";
            this.BtClearAll.UseVisualStyleBackColor = true;
            this.BtClearAll.Click += new System.EventHandler(this.BtClearAll_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(714, 413);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(86, 53);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // gpOtklon
            // 
            this.gpOtklon.Controls.Add(this.label14);
            this.gpOtklon.Controls.Add(this.nmMaxy2);
            this.gpOtklon.Controls.Add(this.nmMiny2);
            this.gpOtklon.Controls.Add(this.label13);
            this.gpOtklon.Controls.Add(this.nmMaxy1);
            this.gpOtklon.Controls.Add(this.nmMiny1);
            this.gpOtklon.Controls.Add(this.label12);
            this.gpOtklon.Controls.Add(this.nmMaxx2);
            this.gpOtklon.Controls.Add(this.nmMinx2);
            this.gpOtklon.Controls.Add(this.label11);
            this.gpOtklon.Controls.Add(this.nmMaxx1);
            this.gpOtklon.Controls.Add(this.label10);
            this.gpOtklon.Controls.Add(this.label9);
            this.gpOtklon.Controls.Add(this.label8);
            this.gpOtklon.Controls.Add(this.label7);
            this.gpOtklon.Controls.Add(this.nmMinx1);
            this.gpOtklon.Location = new System.Drawing.Point(6, 6);
            this.gpOtklon.Name = "gpOtklon";
            this.gpOtklon.Size = new System.Drawing.Size(258, 93);
            this.gpOtklon.TabIndex = 12;
            this.gpOtklon.TabStop = false;
            this.gpOtklon.Text = "Границы отклонения";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(198, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "-";
            // 
            // nmMaxy2
            // 
            this.nmMaxy2.DecimalPlaces = 2;
            this.nmMaxy2.Enabled = false;
            this.nmMaxy2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMaxy2.Location = new System.Drawing.Point(209, 61);
            this.nmMaxy2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMaxy2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmMaxy2.Name = "nmMaxy2";
            this.nmMaxy2.Size = new System.Drawing.Size(44, 20);
            this.nmMaxy2.TabIndex = 14;
            this.nmMaxy2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nmMiny2
            // 
            this.nmMiny2.DecimalPlaces = 2;
            this.nmMiny2.Enabled = false;
            this.nmMiny2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMiny2.Location = new System.Drawing.Point(151, 61);
            this.nmMiny2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMiny2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmMiny2.Name = "nmMiny2";
            this.nmMiny2.Size = new System.Drawing.Size(44, 20);
            this.nmMiny2.TabIndex = 13;
            this.nmMiny2.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "-";
            // 
            // nmMaxy1
            // 
            this.nmMaxy1.DecimalPlaces = 2;
            this.nmMaxy1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMaxy1.Location = new System.Drawing.Point(82, 61);
            this.nmMaxy1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMaxy1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmMaxy1.Name = "nmMaxy1";
            this.nmMaxy1.Size = new System.Drawing.Size(44, 20);
            this.nmMaxy1.TabIndex = 11;
            this.nmMaxy1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nmMiny1
            // 
            this.nmMiny1.DecimalPlaces = 2;
            this.nmMiny1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMiny1.Location = new System.Drawing.Point(24, 61);
            this.nmMiny1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMiny1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmMiny1.Name = "nmMiny1";
            this.nmMiny1.Size = new System.Drawing.Size(44, 20);
            this.nmMiny1.TabIndex = 10;
            this.nmMiny1.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(199, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "-";
            // 
            // nmMaxx2
            // 
            this.nmMaxx2.DecimalPlaces = 2;
            this.nmMaxx2.Enabled = false;
            this.nmMaxx2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMaxx2.Location = new System.Drawing.Point(210, 24);
            this.nmMaxx2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMaxx2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmMaxx2.Name = "nmMaxx2";
            this.nmMaxx2.Size = new System.Drawing.Size(44, 20);
            this.nmMaxx2.TabIndex = 8;
            this.nmMaxx2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nmMinx2
            // 
            this.nmMinx2.DecimalPlaces = 2;
            this.nmMinx2.Enabled = false;
            this.nmMinx2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMinx2.Location = new System.Drawing.Point(152, 24);
            this.nmMinx2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMinx2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmMinx2.Name = "nmMinx2";
            this.nmMinx2.Size = new System.Drawing.Size(44, 20);
            this.nmMinx2.TabIndex = 7;
            this.nmMinx2.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "-";
            // 
            // nmMaxx1
            // 
            this.nmMaxx1.DecimalPlaces = 2;
            this.nmMaxx1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMaxx1.Location = new System.Drawing.Point(82, 24);
            this.nmMaxx1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMaxx1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmMaxx1.Name = "nmMaxx1";
            this.nmMaxx1.Size = new System.Drawing.Size(44, 20);
            this.nmMaxx1.TabIndex = 5;
            this.nmMaxx1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(130, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Y2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(131, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "X2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Y1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "X1";
            // 
            // nmMinx1
            // 
            this.nmMinx1.DecimalPlaces = 2;
            this.nmMinx1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMinx1.Location = new System.Drawing.Point(24, 24);
            this.nmMinx1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMinx1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmMinx1.Name = "nmMinx1";
            this.nmMinx1.Size = new System.Drawing.Size(44, 20);
            this.nmMinx1.TabIndex = 0;
            this.nmMinx1.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(140, 384);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(124, 23);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Сбросить данные";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btAddList
            // 
            this.btAddList.Location = new System.Drawing.Point(7, 383);
            this.btAddList.Name = "btAddList";
            this.btAddList.Size = new System.Drawing.Size(127, 23);
            this.btAddList.TabIndex = 10;
            this.btAddList.Text = "Добавить данные";
            this.btAddList.UseVisualStyleBackColor = true;
            this.btAddList.Click += new System.EventHandler(this.btAddList_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(403, 6);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(129, 23);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Сбросить координаты";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(7, 101);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(258, 277);
            this.lstData.TabIndex = 7;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.graphStart);
            this.tabPage2.Controls.Add(this.lstInfo);
            this.tabPage2.Controls.Add(this.lstArhiv);
            this.tabPage2.Controls.Add(this.mpPick);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Архив данных";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // graphStart
            // 
            this.graphStart.Location = new System.Drawing.Point(238, 186);
            this.graphStart.Name = "graphStart";
            this.graphStart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.Name = "Series1";
            this.graphStart.Series.Add(series2);
            this.graphStart.Size = new System.Drawing.Size(565, 303);
            this.graphStart.TabIndex = 9;
            this.graphStart.Text = "chart1";
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(9, 186);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(223, 303);
            this.lstInfo.TabIndex = 8;
            // 
            // lstArhiv
            // 
            this.lstArhiv.FormattingEnabled = true;
            this.lstArhiv.HorizontalScrollbar = true;
            this.lstArhiv.Location = new System.Drawing.Point(185, 14);
            this.lstArhiv.Name = "lstArhiv";
            this.lstArhiv.ScrollAlwaysVisible = true;
            this.lstArhiv.Size = new System.Drawing.Size(618, 160);
            this.lstArhiv.TabIndex = 2;
            this.lstArhiv.SelectedIndexChanged += new System.EventHandler(this.lstArhiv_SelectedIndexChanged);
            // 
            // mpPick
            // 
            this.mpPick.Location = new System.Drawing.Point(9, 12);
            this.mpPick.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.mpPick.Name = "mpPick";
            this.mpPick.TabIndex = 1;
            this.mpPick.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mpPick_DateSelected);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 528);
            this.Controls.Add(this.tb1);
            this.Name = "Form2";
            this.Text = "Личные данные";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphStabl)).EndInit();
            this.gpLeft.ResumeLayout(false);
            this.gpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmx1)).EndInit();
            this.tb1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpOtklon.ResumeLayout(false);
            this.gpOtklon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiny2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiny1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinx1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graphStabl;
        private System.Windows.Forms.Button btStabl;
        private System.Windows.Forms.Timer tmStart;
        private System.Windows.Forms.GroupBox gpLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmy1;
        private System.Windows.Forms.NumericUpDown nmx1;
        private System.Windows.Forms.TabControl tb1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAddList;
        private System.Windows.Forms.GroupBox gpOtklon;
        private System.Windows.Forms.Button BtClearAll;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nmMaxy2;
        private System.Windows.Forms.NumericUpDown nmMiny2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmMaxy1;
        private System.Windows.Forms.NumericUpDown nmMiny1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmMaxx2;
        private System.Windows.Forms.NumericUpDown nmMinx2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmMaxx1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmMinx1;
        private System.Windows.Forms.Label lbStat;
        private System.Windows.Forms.ListBox lstStat;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.ListBox lstArhiv;
        private System.Windows.Forms.MonthCalendar mpPick;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphStart;
    }
}