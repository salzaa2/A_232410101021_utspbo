namespace _1021_Nadhira_Salzabilla_Istiazah_UTSPBO
{
    partial class Halaman_Welcome
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 26F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(283, 77);
            label3.Name = "label3";
            label3.Size = new Size(224, 58);
            label3.TabIndex = 4;
            label3.Text = "MYBOOK";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 146);
            label1.Name = "label1";
            label1.Size = new Size(292, 25);
            label1.TabIndex = 5;
            label1.Text = "Selamat Datang di aplikasi MyBook";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 171);
            label2.Name = "label2";
            label2.Size = new Size(672, 25);
            label2.TabIndex = 6;
            label2.Text = "MyBook hadir membantu anda dalam mencari buku yang dibutuhkan secara digital";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(180, 275);
            button1.Name = "button1";
            button1.Size = new Size(124, 50);
            button1.TabIndex = 7;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(341, 275);
            button2.Name = "button2";
            button2.Size = new Size(122, 50);
            button2.TabIndex = 8;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Location = new Point(504, 275);
            button3.Name = "button3";
            button3.Size = new Size(123, 50);
            button3.TabIndex = 9;
            button3.Text = "Buku";
            button3.UseVisualStyleBackColor = false;
            // 
            // Halaman_Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Halaman_Welcome";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        //private Button button1;
        //private Button button2;
        //private Button button3;
    }
}
