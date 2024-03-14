namespace WinFormsTrain
{
    partial class AddPersonForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(299, 15);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(299, 44);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Админ ", "Пользователь" });
            comboBox1.Location = new Point(299, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 44);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 76);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 18);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 9;
            label4.Text = "Должность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 49);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Зарплата";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 78);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 11;
            label6.Text = "Роль";
            // 
            // button1
            // 
            button1.Location = new Point(182, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddPersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 237);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AddPersonForm";
            Text = "AddPerson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}