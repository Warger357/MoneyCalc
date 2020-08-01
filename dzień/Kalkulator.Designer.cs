namespace dzień
{
    partial class Kalkulator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ToDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MoneyPerHourNB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.HoursPerDayNB = new System.Windows.Forms.NumericUpDown();
            this.MoneyLAB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CountBTN = new System.Windows.Forms.Button();
            this.SatCB = new System.Windows.Forms.CheckBox();
            this.SunCB = new System.Windows.Forms.CheckBox();
            this.PeriodDGV = new System.Windows.Forms.DataGridView();
            this.EditBTN = new System.Windows.Forms.Button();
            this.labxD = new System.Windows.Forms.Label();
            this.WorkedHoursLAB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPerHourNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursPerDayNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 638);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 592);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rozliczenie Miesięczne";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ToDateDTP, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FromDateDTP, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.MoneyPerHourNB, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.HoursPerDayNB, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.MoneyLAB, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.CountBTN, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.SatCB, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.SunCB, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.PeriodDGV, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.EditBTN, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.labxD, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.WorkedHoursLAB, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(605, 573);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ToDateDTP
            // 
            this.ToDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateDTP.Location = new System.Drawing.Point(305, 38);
            this.ToDateDTP.Name = "ToDateDTP";
            this.ToDateDTP.Size = new System.Drawing.Size(200, 20);
            this.ToDateDTP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(202, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data początkowa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(216, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data końcowa: ";
            // 
            // FromDateDTP
            // 
            this.FromDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateDTP.Location = new System.Drawing.Point(305, 3);
            this.FromDateDTP.Name = "FromDateDTP";
            this.FromDateDTP.Size = new System.Drawing.Size(200, 20);
            this.FromDateDTP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(250, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stawka: ";
            // 
            // MoneyPerHourNB
            // 
            this.MoneyPerHourNB.DecimalPlaces = 2;
            this.MoneyPerHourNB.Location = new System.Drawing.Point(305, 73);
            this.MoneyPerHourNB.Name = "MoneyPerHourNB";
            this.MoneyPerHourNB.Size = new System.Drawing.Size(120, 20);
            this.MoneyPerHourNB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(191, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Godziny w ciągu dnia";
            // 
            // HoursPerDayNB
            // 
            this.HoursPerDayNB.Location = new System.Drawing.Point(305, 108);
            this.HoursPerDayNB.Name = "HoursPerDayNB";
            this.HoursPerDayNB.Size = new System.Drawing.Size(120, 20);
            this.HoursPerDayNB.TabIndex = 7;
            // 
            // MoneyLAB
            // 
            this.MoneyLAB.AutoSize = true;
            this.MoneyLAB.Location = new System.Drawing.Point(305, 245);
            this.MoneyLAB.Name = "MoneyLAB";
            this.MoneyLAB.Size = new System.Drawing.Size(13, 13);
            this.MoneyLAB.TabIndex = 8;
            this.MoneyLAB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(232, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rozliczenie: ";
            // 
            // CountBTN
            // 
            this.CountBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.CountBTN.Location = new System.Drawing.Point(3, 283);
            this.CountBTN.Name = "CountBTN";
            this.CountBTN.Size = new System.Drawing.Size(296, 23);
            this.CountBTN.TabIndex = 10;
            this.CountBTN.Text = "Licz";
            this.CountBTN.UseVisualStyleBackColor = true;
            this.CountBTN.Click += new System.EventHandler(this.CountBTN_Click);
            // 
            // SatCB
            // 
            this.SatCB.AutoSize = true;
            this.SatCB.Location = new System.Drawing.Point(305, 143);
            this.SatCB.Name = "SatCB";
            this.SatCB.Size = new System.Drawing.Size(59, 17);
            this.SatCB.TabIndex = 11;
            this.SatCB.Text = "Soboty";
            this.SatCB.UseVisualStyleBackColor = true;
            // 
            // SunCB
            // 
            this.SunCB.AutoSize = true;
            this.SunCB.Location = new System.Drawing.Point(305, 178);
            this.SunCB.Name = "SunCB";
            this.SunCB.Size = new System.Drawing.Size(69, 17);
            this.SunCB.TabIndex = 12;
            this.SunCB.Text = "Niedziele";
            this.SunCB.UseVisualStyleBackColor = true;
            // 
            // PeriodDGV
            // 
            this.PeriodDGV.AllowUserToAddRows = false;
            this.PeriodDGV.AllowUserToDeleteRows = false;
            this.PeriodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PeriodDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PeriodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.PeriodDGV, 2);
            this.PeriodDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeriodDGV.Location = new System.Drawing.Point(3, 318);
            this.PeriodDGV.Name = "PeriodDGV";
            this.PeriodDGV.Size = new System.Drawing.Size(599, 252);
            this.PeriodDGV.TabIndex = 13;
            this.PeriodDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeriodDGV_CellValueChanged);
            // 
            // EditBTN
            // 
            this.EditBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditBTN.Location = new System.Drawing.Point(305, 283);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(297, 23);
            this.EditBTN.TabIndex = 14;
            this.EditBTN.Text = "Edytuj";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // labxD
            // 
            this.labxD.AutoSize = true;
            this.labxD.Dock = System.Windows.Forms.DockStyle.Right;
            this.labxD.Location = new System.Drawing.Point(171, 210);
            this.labxD.Name = "labxD";
            this.labxD.Size = new System.Drawing.Size(128, 35);
            this.labxD.TabIndex = 15;
            this.labxD.Text = "Godziny Przepracowane: ";
            // 
            // WorkedHoursLAB
            // 
            this.WorkedHoursLAB.AutoSize = true;
            this.WorkedHoursLAB.Location = new System.Drawing.Point(305, 210);
            this.WorkedHoursLAB.Name = "WorkedHoursLAB";
            this.WorkedHoursLAB.Size = new System.Drawing.Size(13, 13);
            this.WorkedHoursLAB.TabIndex = 16;
            this.WorkedHoursLAB.Text = "0";
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPerHourNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursPerDayNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker ToDateDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromDateDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MoneyPerHourNB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown HoursPerDayNB;
        private System.Windows.Forms.Label MoneyLAB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CountBTN;
        private System.Windows.Forms.CheckBox SatCB;
        private System.Windows.Forms.CheckBox SunCB;
        private System.Windows.Forms.DataGridView PeriodDGV;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Label labxD;
        private System.Windows.Forms.Label WorkedHoursLAB;
    }
}

