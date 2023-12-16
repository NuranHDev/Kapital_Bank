namespace Kapital_Bank
{
    partial class Form3
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-7, -20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 114);
            panel1.TabIndex = 2;
            panel1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(389, 81);
            label1.TabIndex = 1;
            label1.Text = "Kapital Bank";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 108);
            label2.Name = "label2";
            label2.Size = new Size(676, 41);
            label2.TabIndex = 3;
            label2.Text = "Məbləği daxil et və \"Təsdiq et\"düyməsini sıxın";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Firebrick;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(354, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 40);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 173);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 5;
            label3.Text = "AZN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 227);
            label4.Name = "label4";
            label4.Size = new Size(0, 41);
            label4.TabIndex = 6;
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 290);
            button1.Name = "button1";
            button1.Size = new Size(331, 53);
            button1.TabIndex = 7;
            button1.Text = "Balans Göstərmək";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(12, 400);
            button2.Name = "button2";
            button2.Size = new Size(331, 53);
            button2.TabIndex = 8;
            button2.Text = "Əsas Menyu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(717, 290);
            button3.Name = "button3";
            button3.Size = new Size(331, 53);
            button3.TabIndex = 9;
            button3.Text = "Təsdiq Et";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(717, 378);
            button4.Name = "button4";
            button4.Size = new Size(331, 53);
            button4.TabIndex = 10;
            button4.Text = "Düzəliş Et";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(717, 471);
            button5.Name = "button5";
            button5.Size = new Size(331, 53);
            button5.TabIndex = 11;
            button5.Text = "İmtina";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(330, 237);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 12;
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(345, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 10);
            panel2.TabIndex = 13;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1070, 576);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form3";
            Text = "Əməliyyat";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private Panel panel2;
    }
}