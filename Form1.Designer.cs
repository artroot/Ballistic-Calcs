namespace BallisticCalcs
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ballisticMotionBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accuracyTrackBar = new System.Windows.Forms.TrackBar();
            this.accuracyText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ballisticMotionBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accuracyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Начальная скорость (м/с)",
            "Угол броска (градус)",
            "Время полета (сек)",
            "Дальность полета (м)",
            "Максимальная высота полета (м)"});
            this.comboBox1.Location = new System.Drawing.Point(22, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Начальная скорость (м/с)";
            this.comboBox1.ValueMember = "1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ballisticMotionBox
            // 
            this.ballisticMotionBox.Controls.Add(this.textBox2);
            this.ballisticMotionBox.Controls.Add(this.textBox1);
            this.ballisticMotionBox.Controls.Add(this.comboBox2);
            this.ballisticMotionBox.Controls.Add(this.comboBox1);
            this.ballisticMotionBox.Location = new System.Drawing.Point(12, 12);
            this.ballisticMotionBox.Name = "ballisticMotionBox";
            this.ballisticMotionBox.Size = new System.Drawing.Size(392, 153);
            this.ballisticMotionBox.TabIndex = 1;
            this.ballisticMotionBox.TabStop = false;
            this.ballisticMotionBox.Text = "Значения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "2";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Начальная скорость (м/с)",
            "Угол броска (градус)",
            "Время полета (сек)",
            "Дальность полета (м)",
            "Максимальная высота полета (м)"});
            this.comboBox2.Location = new System.Drawing.Point(22, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Угол броска (градус)";
            this.comboBox2.ValueMember = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelH);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelS);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расчеты";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(324, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "9.80665";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.accuracyText);
            this.groupBox2.Controls.Add(this.accuracyTrackBar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(420, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поправки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ускорение свободного падения (м/с2)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Точность вычислений";
            // 
            // accuracyTrackBar
            // 
            this.accuracyTrackBar.Location = new System.Drawing.Point(22, 101);
            this.accuracyTrackBar.Maximum = 20;
            this.accuracyTrackBar.Name = "accuracyTrackBar";
            this.accuracyTrackBar.Size = new System.Drawing.Size(324, 45);
            this.accuracyTrackBar.TabIndex = 7;
            this.accuracyTrackBar.Value = 2;
            this.accuracyTrackBar.Scroll += new System.EventHandler(this.accuracyTrackBar_Scroll);
            // 
            // accuracyText
            // 
            this.accuracyText.Location = new System.Drawing.Point(145, 82);
            this.accuracyText.Name = "accuracyText";
            this.accuracyText.Size = new System.Drawing.Size(32, 20);
            this.accuracyText.TabIndex = 8;
            this.accuracyText.Text = "2";
            this.accuracyText.TextChanged += new System.EventHandler(this.accuracyText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "знаков после запятой";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Начальная скорость (м/с)";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV.Location = new System.Drawing.Point(20, 55);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(27, 29);
            this.labelV.TabIndex = 1;
            this.labelV.Text = "0";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(322, 55);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(27, 29);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Угол броска (градус)";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(624, 55);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(27, 29);
            this.labelT.TabIndex = 5;
            this.labelT.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Время полета (сек)";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.Location = new System.Drawing.Point(20, 150);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(27, 29);
            this.labelS.TabIndex = 7;
            this.labelS.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Дальность полета (м)";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(322, 150);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(27, 29);
            this.labelH.TabIndex = 9;
            this.labelH.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Максимальная высота полета (м)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ballisticMotionBox);
            this.Name = "Form1";
            this.Text = "Баллистическое движение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ballisticMotionBox.ResumeLayout(false);
            this.ballisticMotionBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accuracyTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox ballisticMotionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accuracyText;
        private System.Windows.Forms.TrackBar accuracyTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label label4;
    }
}

