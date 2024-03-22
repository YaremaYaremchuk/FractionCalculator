namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            firsttopbox = new TextBox();
            firstbotbox = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            secondbotbox = new TextBox();
            secondtopbox = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            resbotbox = new TextBox();
            restopbox = new TextBox();
            textBox13 = new TextBox();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(207, 70);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 36);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "+";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(207, 148);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 36);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "-";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(207, 237);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 36);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "*";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(207, 326);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(54, 36);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "/";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(33, 474);
            button1.Name = "button1";
            button1.Size = new Size(631, 46);
            button1.TabIndex = 8;
            button1.Text = "Perform Operation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // firsttopbox
            // 
            firsttopbox.Location = new Point(12, 236);
            firsttopbox.Name = "firsttopbox";
            firsttopbox.Size = new Size(42, 39);
            firsttopbox.TabIndex = 0;
            firsttopbox.TextChanged += textBox1_TextChanged;
            // 
            // firstbotbox
            // 
            firstbotbox.Location = new Point(108, 236);
            firstbotbox.Name = "firstbotbox";
            firstbotbox.Size = new Size(42, 39);
            firstbotbox.TabIndex = 1;
            firstbotbox.TextChanged += firstbotbox_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Location = new Point(12, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 32);
            textBox3.TabIndex = 7;
            textBox3.Text = "First";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Location = new Point(320, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 32);
            textBox4.TabIndex = 8;
            textBox4.Text = "Second";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Location = new Point(60, 236);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(42, 32);
            textBox5.TabIndex = 9;
            textBox5.Text = "/";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Enabled = false;
            textBox6.Location = new Point(364, 236);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(42, 32);
            textBox6.TabIndex = 12;
            textBox6.Text = "/";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // secondbotbox
            // 
            secondbotbox.Location = new Point(412, 236);
            secondbotbox.Name = "secondbotbox";
            secondbotbox.Size = new Size(42, 39);
            secondbotbox.TabIndex = 7;
            // 
            // secondtopbox
            // 
            secondtopbox.Location = new Point(316, 236);
            secondtopbox.Name = "secondtopbox";
            secondtopbox.Size = new Size(42, 39);
            secondtopbox.TabIndex = 6;
            secondtopbox.TextChanged += secondtopbox_TextChanged;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Enabled = false;
            textBox9.Location = new Point(460, 236);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(42, 32);
            textBox9.TabIndex = 13;
            textBox9.Text = "=";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Enabled = false;
            textBox10.Location = new Point(574, 236);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(42, 32);
            textBox10.TabIndex = 17;
            textBox10.Text = "/";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // resbotbox
            // 
            resbotbox.Enabled = false;
            resbotbox.Location = new Point(622, 236);
            resbotbox.Name = "resbotbox";
            resbotbox.Size = new Size(42, 39);
            resbotbox.TabIndex = 16;
            // 
            // restopbox
            // 
            restopbox.Enabled = false;
            restopbox.Location = new Point(526, 236);
            restopbox.Name = "restopbox";
            restopbox.Size = new Size(42, 39);
            restopbox.TabIndex = 15;
            // 
            // textBox13
            // 
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Enabled = false;
            textBox13.Location = new Point(530, 161);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(86, 32);
            textBox13.TabIndex = 14;
            textBox13.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 554);
            Controls.Add(textBox10);
            Controls.Add(resbotbox);
            Controls.Add(restopbox);
            Controls.Add(textBox13);
            Controls.Add(textBox9);
            Controls.Add(textBox6);
            Controls.Add(secondbotbox);
            Controls.Add(secondtopbox);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(firstbotbox);
            Controls.Add(firsttopbox);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private TextBox firsttopbox;
        private TextBox firstbotbox;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox secondbotbox;
        private TextBox secondtopbox;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox resbotbox;
        private TextBox restopbox;
        private TextBox textBox13;
    }
}
