namespace De_los_Santos_Calculator
{
    partial class Form1
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lbl_placeholder = new System.Windows.Forms.Label();
            this.btn_c = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_ce = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_times = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_minus = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_divide = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_plus = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_equals = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_0 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_3 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_2 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_1 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_6 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_5 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_4 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_9 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_8 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.btn_7 = new De_los_Santos_Calculator.Custom_Class.RoundButton();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txt_input.Location = new System.Drawing.Point(23, 38);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(504, 72);
            this.txt_input.TabIndex = 0;
            this.txt_input.Text = "0";
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_placeholder
            // 
            this.lbl_placeholder.AutoSize = true;
            this.lbl_placeholder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_placeholder.Location = new System.Drawing.Point(34, 44);
            this.lbl_placeholder.Name = "lbl_placeholder";
            this.lbl_placeholder.Size = new System.Drawing.Size(0, 19);
            this.lbl_placeholder.TabIndex = 1;
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_c.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_c.BorderColor = System.Drawing.Color.Transparent;
            this.btn_c.BorderRadius = 20;
            this.btn_c.borderSize = 0;
            this.btn_c.FlatAppearance.BorderSize = 0;
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_c.ForeColor = System.Drawing.Color.White;
            this.btn_c.Location = new System.Drawing.Point(430, 290);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(86, 63);
            this.btn_c.TabIndex = 23;
            this.btn_c.Text = "C";
            this.btn_c.TextColor = System.Drawing.Color.Empty;
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ce.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_ce.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ce.BorderRadius = 20;
            this.btn_ce.borderSize = 0;
            this.btn_ce.FlatAppearance.BorderSize = 0;
            this.btn_ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ce.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_ce.ForeColor = System.Drawing.Color.White;
            this.btn_ce.Location = new System.Drawing.Point(338, 290);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(86, 63);
            this.btn_ce.TabIndex = 23;
            this.btn_ce.Text = "CE";
            this.btn_ce.TextColor = System.Drawing.Color.Empty;
            this.btn_ce.UseVisualStyleBackColor = false;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // btn_times
            // 
            this.btn_times.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_times.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_times.BorderColor = System.Drawing.Color.Transparent;
            this.btn_times.BorderRadius = 20;
            this.btn_times.borderSize = 0;
            this.btn_times.FlatAppearance.BorderSize = 0;
            this.btn_times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_times.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_times.ForeColor = System.Drawing.Color.White;
            this.btn_times.Location = new System.Drawing.Point(430, 212);
            this.btn_times.Name = "btn_times";
            this.btn_times.Size = new System.Drawing.Size(86, 63);
            this.btn_times.TabIndex = 23;
            this.btn_times.Text = "*";
            this.btn_times.TextColor = System.Drawing.Color.Empty;
            this.btn_times.UseVisualStyleBackColor = false;
            this.btn_times.Click += new System.EventHandler(this.btn_times_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_minus.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_minus.BorderColor = System.Drawing.Color.Transparent;
            this.btn_minus.BorderRadius = 20;
            this.btn_minus.borderSize = 0;
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_minus.ForeColor = System.Drawing.Color.White;
            this.btn_minus.Location = new System.Drawing.Point(338, 212);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(86, 63);
            this.btn_minus.TabIndex = 23;
            this.btn_minus.Text = "-";
            this.btn_minus.TextColor = System.Drawing.Color.Empty;
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_divide.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_divide.BorderColor = System.Drawing.Color.Transparent;
            this.btn_divide.BorderRadius = 20;
            this.btn_divide.borderSize = 0;
            this.btn_divide.FlatAppearance.BorderSize = 0;
            this.btn_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_divide.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_divide.ForeColor = System.Drawing.Color.White;
            this.btn_divide.Location = new System.Drawing.Point(430, 134);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(86, 63);
            this.btn_divide.TabIndex = 23;
            this.btn_divide.Text = "/";
            this.btn_divide.TextColor = System.Drawing.Color.Empty;
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_plus.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_plus.BorderColor = System.Drawing.Color.Transparent;
            this.btn_plus.BorderRadius = 20;
            this.btn_plus.borderSize = 0;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_plus.ForeColor = System.Drawing.Color.White;
            this.btn_plus.Location = new System.Drawing.Point(338, 134);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(86, 63);
            this.btn_plus.TabIndex = 23;
            this.btn_plus.Text = "+";
            this.btn_plus.TextColor = System.Drawing.Color.Empty;
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_equals.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_equals.BorderColor = System.Drawing.Color.Transparent;
            this.btn_equals.BorderRadius = 20;
            this.btn_equals.borderSize = 0;
            this.btn_equals.FlatAppearance.BorderSize = 0;
            this.btn_equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equals.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_equals.ForeColor = System.Drawing.Color.White;
            this.btn_equals.Location = new System.Drawing.Point(338, 369);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(178, 63);
            this.btn_equals.TabIndex = 22;
            this.btn_equals.Text = "=";
            this.btn_equals.TextColor = System.Drawing.Color.Empty;
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_0.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_0.BorderColor = System.Drawing.Color.Transparent;
            this.btn_0.BorderRadius = 20;
            this.btn_0.borderSize = 0;
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(80, 369);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(187, 63);
            this.btn_0.TabIndex = 22;
            this.btn_0.Text = "0";
            this.btn_0.TextColor = System.Drawing.Color.Empty;
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_3.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_3.BorderColor = System.Drawing.Color.Transparent;
            this.btn_3.BorderRadius = 20;
            this.btn_3.borderSize = 0;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(228, 290);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(86, 63);
            this.btn_3.TabIndex = 21;
            this.btn_3.Text = "3";
            this.btn_3.TextColor = System.Drawing.Color.Empty;
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_2.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_2.BorderColor = System.Drawing.Color.Transparent;
            this.btn_2.BorderRadius = 20;
            this.btn_2.borderSize = 0;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(127, 290);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(86, 63);
            this.btn_2.TabIndex = 21;
            this.btn_2.Text = "2";
            this.btn_2.TextColor = System.Drawing.Color.Empty;
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_1.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_1.BorderColor = System.Drawing.Color.Transparent;
            this.btn_1.BorderRadius = 20;
            this.btn_1.borderSize = 0;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(23, 290);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(86, 63);
            this.btn_1.TabIndex = 21;
            this.btn_1.Text = "1";
            this.btn_1.TextColor = System.Drawing.Color.Empty;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_6.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_6.BorderColor = System.Drawing.Color.Transparent;
            this.btn_6.BorderRadius = 20;
            this.btn_6.borderSize = 0;
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(228, 212);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(86, 63);
            this.btn_6.TabIndex = 21;
            this.btn_6.Text = "6";
            this.btn_6.TextColor = System.Drawing.Color.Empty;
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_5.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_5.BorderColor = System.Drawing.Color.Transparent;
            this.btn_5.BorderRadius = 20;
            this.btn_5.borderSize = 0;
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(127, 212);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(86, 63);
            this.btn_5.TabIndex = 21;
            this.btn_5.Text = "5";
            this.btn_5.TextColor = System.Drawing.Color.Empty;
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_4.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_4.BorderColor = System.Drawing.Color.Transparent;
            this.btn_4.BorderRadius = 20;
            this.btn_4.borderSize = 0;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(23, 212);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(86, 63);
            this.btn_4.TabIndex = 21;
            this.btn_4.Text = "4";
            this.btn_4.TextColor = System.Drawing.Color.Empty;
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_9.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_9.BorderColor = System.Drawing.Color.Transparent;
            this.btn_9.BorderRadius = 20;
            this.btn_9.borderSize = 0;
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(228, 134);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(86, 63);
            this.btn_9.TabIndex = 21;
            this.btn_9.Text = "9";
            this.btn_9.TextColor = System.Drawing.Color.Empty;
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_8.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_8.BorderColor = System.Drawing.Color.Transparent;
            this.btn_8.BorderRadius = 20;
            this.btn_8.borderSize = 0;
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(127, 134);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(86, 63);
            this.btn_8.TabIndex = 20;
            this.btn_8.Text = "8";
            this.btn_8.TextColor = System.Drawing.Color.Empty;
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_7.BackgroundColor = System.Drawing.Color.Empty;
            this.btn_7.BorderColor = System.Drawing.Color.Transparent;
            this.btn_7.BorderRadius = 20;
            this.btn_7.borderSize = 0;
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(23, 134);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(86, 63);
            this.btn_7.TabIndex = 19;
            this.btn_7.Text = "7";
            this.btn_7.TextColor = System.Drawing.Color.Empty;
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 455);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_times);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.lbl_placeholder);
            this.Controls.Add(this.txt_input);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lbl_placeholder;
        private Custom_Class.RoundButton btn_7;
        private Custom_Class.RoundButton btn_8;
        private Custom_Class.RoundButton btn_9;
        private Custom_Class.RoundButton btn_4;
        private Custom_Class.RoundButton btn_5;
        private Custom_Class.RoundButton btn_6;
        private Custom_Class.RoundButton btn_1;
        private Custom_Class.RoundButton btn_2;
        private Custom_Class.RoundButton btn_3;
        private Custom_Class.RoundButton btn_0;
        private Custom_Class.RoundButton btn_plus;
        private Custom_Class.RoundButton btn_divide;
        private Custom_Class.RoundButton btn_minus;
        private Custom_Class.RoundButton btn_times;
        private Custom_Class.RoundButton btn_ce;
        private Custom_Class.RoundButton btn_c;
        private Custom_Class.RoundButton btn_equals;
    }
}

