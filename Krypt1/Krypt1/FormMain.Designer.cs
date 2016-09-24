namespace Krypt1
{
    partial class FormMain
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
            this.rbCesar = new System.Windows.Forms.RadioButton();
            this.rbTrit = new System.Windows.Forms.RadioButton();
            this.rbGamm = new System.Windows.Forms.RadioButton();
            this.tb_in1 = new System.Windows.Forms.TextBox();
            this.tb_out1 = new System.Windows.Forms.TextBox();
            this.panelShifr = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbgamm1 = new System.Windows.Forms.TextBox();
            this.nudCesarKey1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudK1 = new System.Windows.Forms.NumericUpDown();
            this.nudB1 = new System.Windows.Forms.NumericUpDown();
            this.btnShifr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDeshifr = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCesarKey2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tbgamm2 = new System.Windows.Forms.TextBox();
            this.nudK2 = new System.Windows.Forms.NumericUpDown();
            this.nudB2 = new System.Windows.Forms.NumericUpDown();
            this.btnDeshifr = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_in2 = new System.Windows.Forms.TextBox();
            this.tb_out2 = new System.Windows.Forms.TextBox();
            this.cbChange = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShifr.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCesarKey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB1)).BeginInit();
            this.panelDeshifr.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCesarKey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCesar
            // 
            this.rbCesar.AutoSize = true;
            this.rbCesar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCesar.Location = new System.Drawing.Point(24, 67);
            this.rbCesar.Name = "rbCesar";
            this.rbCesar.Size = new System.Drawing.Size(134, 24);
            this.rbCesar.TabIndex = 0;
            this.rbCesar.TabStop = true;
            this.rbCesar.Text = "Шифр Цезаря";
            this.rbCesar.UseVisualStyleBackColor = true;
            this.rbCesar.CheckedChanged += new System.EventHandler(this.rbCesar_CheckedChanged);
            // 
            // rbTrit
            // 
            this.rbTrit.AutoSize = true;
            this.rbTrit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTrit.Location = new System.Drawing.Point(24, 130);
            this.rbTrit.Name = "rbTrit";
            this.rbTrit.Size = new System.Drawing.Size(166, 24);
            this.rbTrit.TabIndex = 1;
            this.rbTrit.TabStop = true;
            this.rbTrit.Text = "Шифр Тритеміуса";
            this.rbTrit.UseVisualStyleBackColor = true;
            this.rbTrit.CheckedChanged += new System.EventHandler(this.rbTrit_CheckedChanged);
            // 
            // rbGamm
            // 
            this.rbGamm.AutoSize = true;
            this.rbGamm.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGamm.Location = new System.Drawing.Point(24, 197);
            this.rbGamm.Name = "rbGamm";
            this.rbGamm.Size = new System.Drawing.Size(162, 24);
            this.rbGamm.TabIndex = 2;
            this.rbGamm.TabStop = true;
            this.rbGamm.Text = "Шифр гамування";
            this.rbGamm.UseVisualStyleBackColor = true;
            this.rbGamm.CheckedChanged += new System.EventHandler(this.rbGamm_CheckedChanged);
            // 
            // tb_in1
            // 
            this.tb_in1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_in1.Location = new System.Drawing.Point(3, 120);
            this.tb_in1.Name = "tb_in1";
            this.tb_in1.Size = new System.Drawing.Size(274, 23);
            this.tb_in1.TabIndex = 3;
            this.tb_in1.TextChanged += new System.EventHandler(this.tb_in1_TextChanged);
            // 
            // tb_out1
            // 
            this.tb_out1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_out1.Location = new System.Drawing.Point(0, 232);
            this.tb_out1.Name = "tb_out1";
            this.tb_out1.Size = new System.Drawing.Size(277, 23);
            this.tb_out1.TabIndex = 4;
            // 
            // panelShifr
            // 
            this.panelShifr.Controls.Add(this.label6);
            this.panelShifr.Controls.Add(this.panel2);
            this.panelShifr.Controls.Add(this.btnShifr);
            this.panelShifr.Controls.Add(this.label2);
            this.panelShifr.Controls.Add(this.label1);
            this.panelShifr.Controls.Add(this.tb_in1);
            this.panelShifr.Controls.Add(this.tb_out1);
            this.panelShifr.Location = new System.Drawing.Point(236, 1);
            this.panelShifr.Name = "panelShifr";
            this.panelShifr.Size = new System.Drawing.Size(280, 323);
            this.panelShifr.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Лише російський алфавіт!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbgamm1);
            this.panel2.Controls.Add(this.nudCesarKey1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nudK1);
            this.panel2.Controls.Add(this.nudB1);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 64);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Довжина гамми=довжині тексту для шифрування";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ключ";
            // 
            // tbgamm1
            // 
            this.tbgamm1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbgamm1.Location = new System.Drawing.Point(105, 18);
            this.tbgamm1.Name = "tbgamm1";
            this.tbgamm1.Size = new System.Drawing.Size(100, 23);
            this.tbgamm1.TabIndex = 13;
            // 
            // nudCesarKey1
            // 
            this.nudCesarKey1.Location = new System.Drawing.Point(105, 21);
            this.nudCesarKey1.Name = "nudCesarKey1";
            this.nudCesarKey1.Size = new System.Drawing.Size(79, 20);
            this.nudCesarKey1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(135, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "*t +";
            // 
            // nudK1
            // 
            this.nudK1.Location = new System.Drawing.Point(105, 21);
            this.nudK1.Name = "nudK1";
            this.nudK1.Size = new System.Drawing.Size(35, 20);
            this.nudK1.TabIndex = 10;
            // 
            // nudB1
            // 
            this.nudB1.Location = new System.Drawing.Point(172, 21);
            this.nudB1.Name = "nudB1";
            this.nudB1.Size = new System.Drawing.Size(36, 20);
            this.nudB1.TabIndex = 11;
            // 
            // btnShifr
            // 
            this.btnShifr.BackColor = System.Drawing.Color.Lavender;
            this.btnShifr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShifr.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShifr.Location = new System.Drawing.Point(73, 159);
            this.btnShifr.Name = "btnShifr";
            this.btnShifr.Size = new System.Drawing.Size(131, 27);
            this.btnShifr.TabIndex = 7;
            this.btnShifr.Text = "Зашифрувати";
            this.btnShifr.UseVisualStyleBackColor = false;
            this.btnShifr.Click += new System.EventHandler(this.btnShifr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Зашифрований текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть текст для шифрування";
            // 
            // panelDeshifr
            // 
            this.panelDeshifr.Controls.Add(this.label7);
            this.panelDeshifr.Controls.Add(this.panel4);
            this.panelDeshifr.Controls.Add(this.btnDeshifr);
            this.panelDeshifr.Controls.Add(this.label11);
            this.panelDeshifr.Controls.Add(this.label12);
            this.panelDeshifr.Controls.Add(this.tb_in2);
            this.panelDeshifr.Controls.Add(this.tb_out2);
            this.panelDeshifr.Location = new System.Drawing.Point(515, 1);
            this.panelDeshifr.Name = "panelDeshifr";
            this.panelDeshifr.Size = new System.Drawing.Size(290, 323);
            this.panelDeshifr.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Лише російський алфавіт!";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.nudCesarKey2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.tbgamm2);
            this.panel4.Controls.Add(this.nudK2);
            this.panel4.Controls.Add(this.nudB2);
            this.panel4.Location = new System.Drawing.Point(7, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 64);
            this.panel4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Довжина гамми=довжині тексту для дешифрування";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(41, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ключ";
            // 
            // nudCesarKey2
            // 
            this.nudCesarKey2.Location = new System.Drawing.Point(105, 24);
            this.nudCesarKey2.Name = "nudCesarKey2";
            this.nudCesarKey2.Size = new System.Drawing.Size(79, 20);
            this.nudCesarKey2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(135, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "*t +";
            // 
            // tbgamm2
            // 
            this.tbgamm2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbgamm2.Location = new System.Drawing.Point(105, 21);
            this.tbgamm2.Name = "tbgamm2";
            this.tbgamm2.Size = new System.Drawing.Size(100, 23);
            this.tbgamm2.TabIndex = 13;
            // 
            // nudK2
            // 
            this.nudK2.Location = new System.Drawing.Point(105, 21);
            this.nudK2.Name = "nudK2";
            this.nudK2.Size = new System.Drawing.Size(35, 20);
            this.nudK2.TabIndex = 10;
            // 
            // nudB2
            // 
            this.nudB2.Location = new System.Drawing.Point(172, 21);
            this.nudB2.Name = "nudB2";
            this.nudB2.Size = new System.Drawing.Size(36, 20);
            this.nudB2.TabIndex = 11;
            // 
            // btnDeshifr
            // 
            this.btnDeshifr.BackColor = System.Drawing.Color.Lavender;
            this.btnDeshifr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshifr.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeshifr.Location = new System.Drawing.Point(76, 159);
            this.btnDeshifr.Name = "btnDeshifr";
            this.btnDeshifr.Size = new System.Drawing.Size(131, 27);
            this.btnDeshifr.TabIndex = 7;
            this.btnDeshifr.Text = "Розшифрувати";
            this.btnDeshifr.UseVisualStyleBackColor = false;
            this.btnDeshifr.Click += new System.EventHandler(this.btnDeshifr_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(58, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Розшифрований текст";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(266, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Введіть текст для дешифрування";
            // 
            // tb_in2
            // 
            this.tb_in2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_in2.Location = new System.Drawing.Point(7, 120);
            this.tb_in2.Name = "tb_in2";
            this.tb_in2.Size = new System.Drawing.Size(272, 23);
            this.tb_in2.TabIndex = 3;
            this.tb_in2.TextChanged += new System.EventHandler(this.tb_in2_TextChanged);
            // 
            // tb_out2
            // 
            this.tb_out2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_out2.Location = new System.Drawing.Point(7, 232);
            this.tb_out2.Name = "tb_out2";
            this.tb_out2.Size = new System.Drawing.Size(272, 23);
            this.tb_out2.TabIndex = 4;
            // 
            // cbChange
            // 
            this.cbChange.FormattingEnabled = true;
            this.cbChange.Location = new System.Drawing.Point(24, 290);
            this.cbChange.Name = "cbChange";
            this.cbChange.Size = new System.Drawing.Size(190, 21);
            this.cbChange.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(512, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 328);
            this.panel1.TabIndex = 17;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbChange);
            this.Controls.Add(this.panelDeshifr);
            this.Controls.Add(this.panelShifr);
            this.Controls.Add(this.rbGamm);
            this.Controls.Add(this.rbTrit);
            this.Controls.Add(this.rbCesar);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panelShifr.ResumeLayout(false);
            this.panelShifr.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCesarKey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB1)).EndInit();
            this.panelDeshifr.ResumeLayout(false);
            this.panelDeshifr.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCesarKey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCesar;
        private System.Windows.Forms.RadioButton rbTrit;
        private System.Windows.Forms.RadioButton rbGamm;
        private System.Windows.Forms.TextBox tb_in1;
        private System.Windows.Forms.TextBox tb_out1;
        private System.Windows.Forms.Panel panelShifr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCesarKey1;
        private System.Windows.Forms.Button btnShifr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudB1;
        private System.Windows.Forms.NumericUpDown nudK1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbgamm1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelDeshifr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbgamm2;
        private System.Windows.Forms.NumericUpDown nudCesarKey2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudK2;
        private System.Windows.Forms.NumericUpDown nudB2;
        private System.Windows.Forms.Button btnDeshifr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_in2;
        private System.Windows.Forms.TextBox tb_out2;
        private System.Windows.Forms.ComboBox cbChange;
        private System.Windows.Forms.Panel panel1;
    }
}

