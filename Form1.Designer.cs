
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CbSlant = new System.Windows.Forms.CheckBox();
            this.CbCutout = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCutout = new System.Windows.Forms.Panel();
            this.NudCutHeightOdch = new System.Windows.Forms.NumericUpDown();
            this.NudCutHeight = new System.Windows.Forms.NumericUpDown();
            this.NudCutWidth = new System.Windows.Forms.NumericUpDown();
            this.NudCutWidthOdch = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PSlant = new System.Windows.Forms.Panel();
            this.NudSlantHeight = new System.Windows.Forms.NumericUpDown();
            this.NudSlantAngle = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSzB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOdchB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSzC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOdchC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PCutout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCutHeightOdch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCutHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCutWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCutWidthOdch)).BeginInit();
            this.PSlant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSlantHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSlantAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDWys
            // 
            this.NUDWys.Location = new System.Drawing.Point(33, 78);
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
            this.NUDWys.Size = new System.Drawing.Size(76, 20);
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
            this.CBStrona.Location = new System.Drawing.Point(9, 38);
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
            this.CBColor.Location = new System.Drawing.Point(139, 38);
            this.CBColor.Name = "CBColor";
            this.CBColor.Size = new System.Drawing.Size(121, 21);
            this.CBColor.TabIndex = 2;
            this.CBColor.SelectedIndexChanged += new System.EventHandler(this.CBColor_SelectedIndexChanged);
            // 
            // NUDSzB
            // 
            this.NUDSzB.Location = new System.Drawing.Point(33, 104);
            this.NUDSzB.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDSzB.Name = "NUDSzB";
            this.NUDSzB.Size = new System.Drawing.Size(76, 20);
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
            this.NUDOdchB.Location = new System.Drawing.Point(162, 104);
            this.NUDOdchB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDOdchB.Name = "NUDOdchB";
            this.NUDOdchB.Size = new System.Drawing.Size(76, 20);
            this.NUDOdchB.TabIndex = 4;
            this.NUDOdchB.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // NUDSzC
            // 
            this.NUDSzC.Location = new System.Drawing.Point(33, 130);
            this.NUDSzC.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDSzC.Name = "NUDSzC";
            this.NUDSzC.Size = new System.Drawing.Size(76, 20);
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
            this.NUDOdchC.Location = new System.Drawing.Point(162, 130);
            this.NUDOdchC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDOdchC.Name = "NUDOdchC";
            this.NUDOdchC.Size = new System.Drawing.Size(76, 20);
            this.NUDOdchC.TabIndex = 6;
            this.NUDOdchC.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(9, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(95, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Policz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "B±";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "C±";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Side";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Zamówienie";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(244, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CbSlant
            // 
            this.CbSlant.AutoSize = true;
            this.CbSlant.Location = new System.Drawing.Point(3, 3);
            this.CbSlant.Name = "CbSlant";
            this.CbSlant.Size = new System.Drawing.Size(50, 17);
            this.CbSlant.TabIndex = 19;
            this.CbSlant.Text = "Slant";
            this.CbSlant.UseVisualStyleBackColor = true;
            this.CbSlant.CheckedChanged += new System.EventHandler(this.CbSlant_CheckedChanged);
            // 
            // CbCutout
            // 
            this.CbCutout.AutoSize = true;
            this.CbCutout.Location = new System.Drawing.Point(3, 3);
            this.CbCutout.Name = "CbCutout";
            this.CbCutout.Size = new System.Drawing.Size(57, 17);
            this.CbCutout.TabIndex = 20;
            this.CbCutout.Text = "Cutout";
            this.CbCutout.UseVisualStyleBackColor = true;
            this.CbCutout.CheckedChanged += new System.EventHandler(this.CbCutout_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.PCutout);
            this.panel1.Controls.Add(this.PSlant);
            this.panel1.Location = new System.Drawing.Point(9, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 214);
            this.panel1.TabIndex = 21;
            // 
            // PCutout
            // 
            this.PCutout.Controls.Add(this.CbCutout);
            this.PCutout.Controls.Add(this.NudCutHeightOdch);
            this.PCutout.Controls.Add(this.NudCutHeight);
            this.PCutout.Controls.Add(this.NudCutWidth);
            this.PCutout.Controls.Add(this.NudCutWidthOdch);
            this.PCutout.Controls.Add(this.label14);
            this.PCutout.Controls.Add(this.label11);
            this.PCutout.Controls.Add(this.label13);
            this.PCutout.Controls.Add(this.label12);
            this.PCutout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PCutout.Location = new System.Drawing.Point(0, 20);
            this.PCutout.MaximumSize = new System.Drawing.Size(244, 80);
            this.PCutout.MinimumSize = new System.Drawing.Size(244, 20);
            this.PCutout.Name = "PCutout";
            this.PCutout.Size = new System.Drawing.Size(244, 20);
            this.PCutout.TabIndex = 1;
            // 
            // NudCutHeightOdch
            // 
            this.NudCutHeightOdch.Enabled = false;
            this.NudCutHeightOdch.Location = new System.Drawing.Point(156, 21);
            this.NudCutHeightOdch.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NudCutHeightOdch.Name = "NudCutHeightOdch";
            this.NudCutHeightOdch.Size = new System.Drawing.Size(76, 20);
            this.NudCutHeightOdch.TabIndex = 4;
            this.NudCutHeightOdch.Visible = false;
            this.NudCutHeightOdch.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // NudCutHeight
            // 
            this.NudCutHeight.Location = new System.Drawing.Point(27, 21);
            this.NudCutHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NudCutHeight.Name = "NudCutHeight";
            this.NudCutHeight.Size = new System.Drawing.Size(76, 20);
            this.NudCutHeight.TabIndex = 3;
            this.NudCutHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NudCutHeight.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // NudCutWidth
            // 
            this.NudCutWidth.Location = new System.Drawing.Point(27, 47);
            this.NudCutWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NudCutWidth.Name = "NudCutWidth";
            this.NudCutWidth.Size = new System.Drawing.Size(76, 20);
            this.NudCutWidth.TabIndex = 5;
            this.NudCutWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudCutWidth.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // NudCutWidthOdch
            // 
            this.NudCutWidthOdch.Enabled = false;
            this.NudCutWidthOdch.Location = new System.Drawing.Point(156, 47);
            this.NudCutWidthOdch.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NudCutWidthOdch.Name = "NudCutWidthOdch";
            this.NudCutWidthOdch.Size = new System.Drawing.Size(76, 20);
            this.NudCutWidthOdch.TabIndex = 6;
            this.NudCutWidthOdch.Visible = false;
            this.NudCutWidthOdch.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Cc±";
            this.label14.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ac";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ac±";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cc";
            // 
            // PSlant
            // 
            this.PSlant.Controls.Add(this.CbSlant);
            this.PSlant.Controls.Add(this.NudSlantHeight);
            this.PSlant.Controls.Add(this.NudSlantAngle);
            this.PSlant.Controls.Add(this.label9);
            this.PSlant.Controls.Add(this.label10);
            this.PSlant.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSlant.Location = new System.Drawing.Point(0, 0);
            this.PSlant.MaximumSize = new System.Drawing.Size(244, 80);
            this.PSlant.MinimumSize = new System.Drawing.Size(244, 20);
            this.PSlant.Name = "PSlant";
            this.PSlant.Size = new System.Drawing.Size(244, 20);
            this.PSlant.TabIndex = 0;
            // 
            // NudSlantHeight
            // 
            this.NudSlantHeight.Location = new System.Drawing.Point(47, 21);
            this.NudSlantHeight.Maximum = new decimal(new int[] {
            2300,
            0,
            0,
            0});
            this.NudSlantHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudSlantHeight.Name = "NudSlantHeight";
            this.NudSlantHeight.Size = new System.Drawing.Size(76, 20);
            this.NudSlantHeight.TabIndex = 0;
            this.NudSlantHeight.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.NudSlantHeight.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // NudSlantAngle
            // 
            this.NudSlantAngle.Location = new System.Drawing.Point(47, 47);
            this.NudSlantAngle.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.NudSlantAngle.Minimum = new decimal(new int[] {
            91,
            0,
            0,
            0});
            this.NudSlantAngle.Name = "NudSlantAngle";
            this.NudSlantAngle.Size = new System.Drawing.Size(76, 20);
            this.NudSlantAngle.TabIndex = 3;
            this.NudSlantAngle.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
            this.NudSlantAngle.ValueChanged += new System.EventHandler(this.NUDWys_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Angle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDWys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSzB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOdchB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSzC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOdchC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PCutout.ResumeLayout(false);
            this.PCutout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCutHeightOdch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCutHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCutWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCutWidthOdch)).EndInit();
            this.PSlant.ResumeLayout(false);
            this.PSlant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSlantHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSlantAngle)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox CbSlant;
        private System.Windows.Forms.CheckBox CbCutout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PCutout;
        private System.Windows.Forms.NumericUpDown NudCutHeightOdch;
        private System.Windows.Forms.NumericUpDown NudCutHeight;
        private System.Windows.Forms.NumericUpDown NudCutWidth;
        private System.Windows.Forms.NumericUpDown NudCutWidthOdch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel PSlant;
        private System.Windows.Forms.NumericUpDown NudSlantHeight;
        private System.Windows.Forms.NumericUpDown NudSlantAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

