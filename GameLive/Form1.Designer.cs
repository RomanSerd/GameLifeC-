
namespace GameLive
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cDensity = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.nDensity = new System.Windows.Forms.NumericUpDown();
            this.Размер = new System.Windows.Forms.Label();
            this.nResolution = new System.Windows.Forms.NumericUpDown();
            this.ResolutionL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cDensity);
            this.splitContainer1.Panel1.Controls.Add(this.bClear);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bPause);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.nDensity);
            this.splitContainer1.Panel1.Controls.Add(this.Размер);
            this.splitContainer1.Panel1.Controls.Add(this.nResolution);
            this.splitContainer1.Panel1.Controls.Add(this.ResolutionL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1175, 619);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 0;
            // 
            // cDensity
            // 
            this.cDensity.AutoSize = true;
            this.cDensity.Checked = true;
            this.cDensity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cDensity.Location = new System.Drawing.Point(136, 79);
            this.cDensity.Name = "cDensity";
            this.cDensity.Size = new System.Drawing.Size(38, 17);
            this.cDensity.TabIndex = 10;
            this.cDensity.Text = "Fill";
            this.cDensity.UseVisualStyleBackColor = true;
            this.cDensity.CheckedChanged += new System.EventHandler(this.cDensity_CheckedChanged);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bClear.Location = new System.Drawing.Point(10, 295);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(120, 37);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rate";
            // 
            // bStop
            // 
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bStop.Location = new System.Drawing.Point(10, 209);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(120, 37);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bPause
            // 
            this.bPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bPause.Location = new System.Drawing.Point(10, 252);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(120, 37);
            this.bPause.TabIndex = 5;
            this.bPause.Text = "Pause/Start";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bStart.Location = new System.Drawing.Point(10, 166);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(120, 37);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // nDensity
            // 
            this.nDensity.Location = new System.Drawing.Point(10, 78);
            this.nDensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDensity.Name = "nDensity";
            this.nDensity.Size = new System.Drawing.Size(120, 20);
            this.nDensity.TabIndex = 3;
            this.nDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Размер
            // 
            this.Размер.AutoSize = true;
            this.Размер.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Размер.Location = new System.Drawing.Point(9, 55);
            this.Размер.Name = "Размер";
            this.Размер.Size = new System.Drawing.Size(69, 20);
            this.Размер.TabIndex = 2;
            this.Размер.Text = "Density";
            // 
            // nResolution
            // 
            this.nResolution.Location = new System.Drawing.Point(10, 30);
            this.nResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nResolution.Name = "nResolution";
            this.nResolution.Size = new System.Drawing.Size(120, 20);
            this.nResolution.TabIndex = 1;
            this.nResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nResolution.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ResolutionL
            // 
            this.ResolutionL.AutoSize = true;
            this.ResolutionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResolutionL.Location = new System.Drawing.Point(9, 7);
            this.ResolutionL.Name = "ResolutionL";
            this.ResolutionL.Size = new System.Drawing.Size(95, 20);
            this.ResolutionL.TabIndex = 0;
            this.ResolutionL.Text = "Resolution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 615);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(13, 124);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            131072});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 8;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.Value = new decimal(new int[] {
            4,
            0,
            0,
            131072});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 619);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.NumericUpDown nDensity;
        private System.Windows.Forms.Label Размер;
        private System.Windows.Forms.NumericUpDown nResolution;
        private System.Windows.Forms.Label ResolutionL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.CheckBox cDensity;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

