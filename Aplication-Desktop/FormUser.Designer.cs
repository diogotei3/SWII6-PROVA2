namespace AplicationDesktop
{
    partial class FormUser
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
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button4 = new Button();
            label7 = new Label();
            checkBox1 = new CheckBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 66);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 394);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(259, 40);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(240, 420);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(232, 392);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 122);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(52, 49);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 18);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(6, 82);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(220, 22);
            button2.TabIndex = 2;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 49);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(232, 392);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detalhes";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(123, 145);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(103, 22);
            button4.TabIndex = 20;
            button4.Text = "Deletar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 18);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 19;
            label7.Text = "0";
            label7.Click += label7_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(52, 114);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 18;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(52, 80);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(174, 23);
            textBox6.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 113);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 16;
            label5.Text = "Ativo";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 80);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 15;
            label6.Text = "Senha";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(52, 49);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(6, 145);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(111, 22);
            button3.TabIndex = 12;
            button3.Text = "Salvar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 49);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 10;
            label4.Text = "Id";
            label4.Click += label4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(149, 8);
            label8.Name = "label8";
            label8.Size = new Size(209, 30);
            label8.TabIndex = 3;
            label8.Text = "Trabalho Final SWII6";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 468);
            Controls.Add(label8);
            Controls.Add(tabControl1);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label7;
        private CheckBox checkBox1;
        private Button button4;
        private Label label8;
        private Label label9;
    }
}