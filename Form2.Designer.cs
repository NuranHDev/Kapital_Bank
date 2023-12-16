namespace Kapital_Bank
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 95);
            panel1.TabIndex = 1;
            panel1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(389, 81);
            label1.TabIndex = 1;
            label1.Text = "Kapital Bank";
            label1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(35, 227);
            button1.Name = "button1";
            button1.Size = new Size(221, 62);
            button1.TabIndex = 2;
            button1.Text = "Xidmətlər";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(35, 425);
            button2.Name = "button2";
            button2.Size = new Size(221, 62);
            button2.TabIndex = 3;
            button2.Text = "English";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(716, 245);
            button3.Name = "button3";
            button3.Size = new Size(315, 62);
            button3.TabIndex = 4;
            button3.Text = "Nağdlaşdırma(AZN)";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(716, 339);
            button4.Name = "button4";
            button4.Size = new Size(315, 62);
            button4.TabIndex = 5;
            button4.Text = "Hesabdan Çıxış";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(345, 136);
            label2.Name = "label2";
            label2.Size = new Size(407, 41);
            label2.TabIndex = 6;
            label2.Text = "Xahiş edirik əməliyyat seçin";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1070, 576);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form2";
            Text = "Əsas Səhifə";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
    }
}