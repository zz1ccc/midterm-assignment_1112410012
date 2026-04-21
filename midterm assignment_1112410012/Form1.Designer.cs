namespace midterm_assignment_1112410012
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
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            checkedListBox1 = new CheckedListBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(37, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(99, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(37, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(81, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 53);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(113, 155);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 5;
            label1.Text = "姓名:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 86);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "性別";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 155);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "出生年月日";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 203);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "入職日期";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(113, 203);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 250);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "興趣";
            label5.Click += label5_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "打球", "上網", "打遊戲" });
            checkedListBox1.Location = new Point(113, 250);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(197, 166);
            checkedListBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 25);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 12;
            label6.Text = "通訊地址";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(524, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 23);
            textBox2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 25);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 14;
            label7.Text = "國籍";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(463, 86);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "電話號碼";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(463, 155);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 16;
            label9.Text = "電子郵件";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "本國籍", "外國籍" });
            comboBox1.Location = new Point(291, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(524, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(524, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 23);
            textBox4.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(463, 203);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 20;
            label10.Text = "備註";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(524, 200);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(293, 134);
            textBox5.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(742, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(839, 25);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(293, 309);
            textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(151, 390);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(257, 390);
            button2.Name = "button2";
            button2.Size = new Size(49, 23);
            button2.TabIndex = 26;
            button2.Text = "新增";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 473);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(checkedListBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private CheckedListBox checkedListBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private Button button1;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button2;
    }
}
