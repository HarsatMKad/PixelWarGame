namespace Game
{
  partial class MainForm
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label1 = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label5 = new System.Windows.Forms.Label();
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.progressBar2 = new System.Windows.Forms.ProgressBar();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // chart1
      // 
      chartArea12.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea12);
      this.chart1.Location = new System.Drawing.Point(8, 9);
      this.chart1.Name = "chart1";
      this.chart1.Size = new System.Drawing.Size(850, 850);
      this.chart1.TabIndex = 1;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 24);
      this.label1.TabIndex = 2;
      this.label1.Text = "Здоровье";
      // 
      // progressBar1
      // 
      this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
      this.progressBar1.Location = new System.Drawing.Point(121, 6);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(100, 23);
      this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBar1.TabIndex = 3;
      this.progressBar1.Value = 100;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(147, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "100/100";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(117, 50);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(18, 20);
      this.label3.TabIndex = 5;
      this.label3.Text = "0";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(6, 46);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(62, 24);
      this.label4.TabIndex = 6;
      this.label4.Text = "Атака";
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(946, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 24);
      this.label5.TabIndex = 8;
      this.label5.Text = "00:00";
      // 
      // timer2
      // 
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(883, 208);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(167, 18);
      this.label6.TabIndex = 9;
      this.label6.Text = "Уничтожено пикселей:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(1051, 208);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(16, 18);
      this.label7.TabIndex = 10;
      this.label7.Text = "0";
      // 
      // progressBar2
      // 
      this.progressBar2.Location = new System.Drawing.Point(6, 121);
      this.progressBar2.Name = "progressBar2";
      this.progressBar2.Size = new System.Drawing.Size(211, 11);
      this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBar2.TabIndex = 11;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.progressBar2);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.progressBar1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(864, 55);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(225, 139);
      this.panel1.TabIndex = 12;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(100, 101);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(16, 17);
      this.label8.TabIndex = 12;
      this.label8.Text = "0";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(6, 27);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(129, 20);
      this.label9.TabIndex = 13;
      this.label9.Text = "Перемещаться:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel2.Controls.Add(this.label17);
      this.panel2.Controls.Add(this.label16);
      this.panel2.Controls.Add(this.label15);
      this.panel2.Controls.Add(this.label14);
      this.panel2.Controls.Add(this.label13);
      this.panel2.Controls.Add(this.label12);
      this.panel2.Controls.Add(this.label11);
      this.panel2.Controls.Add(this.label10);
      this.panel2.Controls.Add(this.label9);
      this.panel2.Location = new System.Drawing.Point(866, 423);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(219, 146);
      this.panel2.TabIndex = 14;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(159, 4);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(24, 20);
      this.label10.TabIndex = 14;
      this.label10.Text = "W";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label11.Location = new System.Drawing.Point(135, 27);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(20, 20);
      this.label11.TabIndex = 15;
      this.label11.Text = "A";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label12.Location = new System.Drawing.Point(159, 27);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(20, 20);
      this.label12.TabIndex = 16;
      this.label12.Text = "S";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label13.Location = new System.Drawing.Point(185, 27);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(21, 20);
      this.label13.TabIndex = 17;
      this.label13.Text = "D";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label14.Location = new System.Drawing.Point(6, 67);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(59, 20);
      this.label14.TabIndex = 18;
      this.label14.Text = "Атака:";
      this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label15.Location = new System.Drawing.Point(135, 67);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(44, 20);
      this.label15.TabIndex = 19;
      this.label15.Text = "ЛКМ";
      this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label16.Location = new System.Drawing.Point(6, 108);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(62, 20);
      this.label16.TabIndex = 20;
      this.label16.Text = "Выход:";
      this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label17.Location = new System.Drawing.Point(135, 108);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(36, 20);
      this.label17.TabIndex = 21;
      this.label17.Text = "Esc";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1091, 867);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.chart1);
      this.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.Name = "MainForm";
      this.Text = "Pixel War";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ProgressBar progressBar2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
  }
}