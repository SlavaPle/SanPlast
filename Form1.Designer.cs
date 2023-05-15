
namespace SanPlast
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
            this.NUDWys = new System.Windows.Forms.NumericUpDown();
            this.CBStrona = new System.Windows.Forms.ComboBox();
            this.CBColor = new System.Windows.Forms.ComboBox();
            this.NUDSzB = new System.Windows.Forms.NumericUpDown();
            this.NUDOdchB = new System.Windows.Forms.NumericUpDown();
            this.NUDSzC = new System.Windows.Forms.NumericUpDown();
            this.NUDOdchC = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSzB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOdchB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSzC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOdchC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDWys
            // 
            this.NUDWys.Location = new System.Drawing.Point(12, 76);
            this.NUDWys.Maximum = new decimal(new int[] {
            2300,
            0,
            0,
            0});
            this.NUDWys.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUDWys.Name = "NUDWys";
            this.NUDWys.Size = new System.Drawing.Size(120, 20);
            this.NUDWys.TabIndex = 0;
            this.NUDWys.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDWys.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // CBStrona
            // 
            this.CBStrona.AutoCompleteCustomSource.AddRange(new string[] {
            "L",
            "R"});
            this.CBStrona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStrona.FormattingEnabled = true;
            this.CBStrona.Items.AddRange(new object[] {
            "L",
            "R"});
            this.CBStrona.Location = new System.Drawing.Point(13, 27);
            this.CBStrona.Name = "CBStrona";
            this.CBStrona.Size = new System.Drawing.Size(121, 21);
            this.CBStrona.TabIndex = 1;
            this.CBStrona.SelectedIndexChanged += new System.EventHandler(this.CBStrona_SelectedIndexChanged);
            // 
            // CBColor
            // 
            this.CBColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColor.FormattingEnabled = true;
            this.CBColor.Items.AddRange(new object[] {
            "Transparentna W0",
            "SATYNA"});
            this.CBColor.Location = new System.Drawing.Point(140, 27);
            this.CBColor.Name = "CBColor";
            this.CBColor.Size = new System.Drawing.Size(121, 21);
            this.CBColor.TabIndex = 2;
            this.CBColor.SelectedIndexChanged += new System.EventHandler(this.CBColor_SelectedIndexChanged);
            // 
            // NUDSzB
            // 
            this.NUDSzB.Location = new System.Drawing.Point(12, 102);
            this.NUDSzB.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDSzB.Name = "NUDSzB";
            this.NUDSzB.Size = new System.Drawing.Size(120, 20);
            this.NUDSzB.TabIndex = 3;
            this.NUDSzB.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.NUDSzB.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // NUDOdchB
            // 
            this.NUDOdchB.Location = new System.Drawing.Point(141, 102);
            this.NUDOdchB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDOdchB.Name = "NUDOdchB";
            this.NUDOdchB.Size = new System.Drawing.Size(120, 20);
            this.NUDOdchB.TabIndex = 4;
            this.NUDOdchB.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // NUDSzC
            // 
            this.NUDSzC.Location = new System.Drawing.Point(12, 128);
            this.NUDSzC.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDSzC.Name = "NUDSzC";
            this.NUDSzC.Size = new System.Drawing.Size(120, 20);
            this.NUDSzC.TabIndex = 5;
            this.NUDSzC.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.NUDSzC.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // NUDOdchC
            // 
            this.NUDOdchC.Location = new System.Drawing.Point(141, 128);
            this.NUDOdchC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDOdchC.Name = "NUDOdchC";
            this.NUDOdchC.Size = new System.Drawing.Size(120, 20);
            this.NUDOdchC.TabIndex = 6;
            this.NUDOdchC.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Policz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NUDOdchC);
            this.Controls.Add(this.NUDSzC);
            this.Controls.Add(this.NUDOdchB);
            this.Controls.Add(this.NUDSzB);
            this.Controls.Add(this.CBColor);
            this.Controls.Add(this.CBStrona);
            this.Controls.Add(this.NUDWys);
            this.Name = "Form1";
            this.Text = "SanPlast";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDWys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSzB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOdchB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSzC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOdchC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDWys;
        private System.Windows.Forms.ComboBox CBStrona;
        private System.Windows.Forms.ComboBox CBColor;
        private System.Windows.Forms.NumericUpDown NUDSzB;
        private System.Windows.Forms.NumericUpDown NUDOdchB;
        private System.Windows.Forms.NumericUpDown NUDSzC;
        private System.Windows.Forms.NumericUpDown NUDOdchC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

