
namespace _59354_2_3.AJ_59354_algorytmLZW
{
    partial class AJ_59354_lzwForm
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
            this.AJ_59354_lzwLabel1 = new System.Windows.Forms.Label();
            this.AJ_59354_lzwLabel2 = new System.Windows.Forms.Label();
            this.AJ_59354_lzwTextBox1 = new System.Windows.Forms.TextBox();
            this.AJ_59354_lzwButton1 = new System.Windows.Forms.Button();
            this.AJ_59354_lzwLabel3 = new System.Windows.Forms.Label();
            this.AJ_59354_lzwTextBox2 = new System.Windows.Forms.TextBox();
            this.AJ_59354_lzwButton2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AJ_59354_lzwLabel1
            // 
            this.AJ_59354_lzwLabel1.AutoSize = true;
            this.AJ_59354_lzwLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AJ_59354_lzwLabel1.Location = new System.Drawing.Point(13, 13);
            this.AJ_59354_lzwLabel1.Name = "AJ_59354_lzwLabel1";
            this.AJ_59354_lzwLabel1.Size = new System.Drawing.Size(153, 16);
            this.AJ_59354_lzwLabel1.TabIndex = 0;
            this.AJ_59354_lzwLabel1.Text = "Algorytm kompresji LZW";
            // 
            // AJ_59354_lzwLabel2
            // 
            this.AJ_59354_lzwLabel2.AutoSize = true;
            this.AJ_59354_lzwLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AJ_59354_lzwLabel2.Location = new System.Drawing.Point(13, 32);
            this.AJ_59354_lzwLabel2.Name = "AJ_59354_lzwLabel2";
            this.AJ_59354_lzwLabel2.Size = new System.Drawing.Size(239, 16);
            this.AJ_59354_lzwLabel2.TabIndex = 1;
            this.AJ_59354_lzwLabel2.Text = "Ciąg do kompresji generowany losowo";
            // 
            // AJ_59354_lzwTextBox1
            // 
            this.AJ_59354_lzwTextBox1.Location = new System.Drawing.Point(13, 51);
            this.AJ_59354_lzwTextBox1.Name = "AJ_59354_lzwTextBox1";
            this.AJ_59354_lzwTextBox1.Size = new System.Drawing.Size(369, 23);
            this.AJ_59354_lzwTextBox1.TabIndex = 2;
            // 
            // AJ_59354_lzwButton1
            // 
            this.AJ_59354_lzwButton1.AutoSize = true;
            this.AJ_59354_lzwButton1.Location = new System.Drawing.Point(388, 51);
            this.AJ_59354_lzwButton1.Name = "AJ_59354_lzwButton1";
            this.AJ_59354_lzwButton1.Size = new System.Drawing.Size(81, 25);
            this.AJ_59354_lzwButton1.TabIndex = 3;
            this.AJ_59354_lzwButton1.Text = "Generuj kod";
            this.AJ_59354_lzwButton1.UseVisualStyleBackColor = true;
            this.AJ_59354_lzwButton1.Click += new System.EventHandler(this.AJ_59354_button1Click);
            // 
            // AJ_59354_lzwLabel3
            // 
            this.AJ_59354_lzwLabel3.AutoSize = true;
            this.AJ_59354_lzwLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AJ_59354_lzwLabel3.Location = new System.Drawing.Point(13, 77);
            this.AJ_59354_lzwLabel3.Name = "AJ_59354_lzwLabel3";
            this.AJ_59354_lzwLabel3.Size = new System.Drawing.Size(112, 16);
            this.AJ_59354_lzwLabel3.TabIndex = 4;
            this.AJ_59354_lzwLabel3.Text = "Kod po kompresji";
            // 
            // AJ_59354_lzwTextBox2
            // 
            this.AJ_59354_lzwTextBox2.Location = new System.Drawing.Point(13, 96);
            this.AJ_59354_lzwTextBox2.Name = "AJ_59354_lzwTextBox2";
            this.AJ_59354_lzwTextBox2.Size = new System.Drawing.Size(369, 23);
            this.AJ_59354_lzwTextBox2.TabIndex = 5;
            // 
            // AJ_59354_lzwButton2
            // 
            this.AJ_59354_lzwButton2.Location = new System.Drawing.Point(389, 95);
            this.AJ_59354_lzwButton2.Name = "AJ_59354_lzwButton2";
            this.AJ_59354_lzwButton2.Size = new System.Drawing.Size(75, 23);
            this.AJ_59354_lzwButton2.TabIndex = 6;
            this.AJ_59354_lzwButton2.Text = "Kompresuj";
            this.AJ_59354_lzwButton2.UseVisualStyleBackColor = true;
            this.AJ_59354_lzwButton2.Click += new System.EventHandler(this.AJ_59354_button2Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AJ_59354_reset);
            // 
            // AJ_59354_lzwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AJ_59354_lzwButton2);
            this.Controls.Add(this.AJ_59354_lzwTextBox2);
            this.Controls.Add(this.AJ_59354_lzwLabel3);
            this.Controls.Add(this.AJ_59354_lzwButton1);
            this.Controls.Add(this.AJ_59354_lzwTextBox1);
            this.Controls.Add(this.AJ_59354_lzwLabel2);
            this.Controls.Add(this.AJ_59354_lzwLabel1);
            this.MaximizeBox = false;
            this.Name = "AJ_59354_lzwForm";
            this.ShowIcon = false;
            this.Text = "ALgorytm kompresji LZW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AJ_59354_lzwLabel1;
        private System.Windows.Forms.Label AJ_59354_lzwLabel2;
        private System.Windows.Forms.TextBox AJ_59354_lzwTextBox1;
        private System.Windows.Forms.Button AJ_59354_lzwButton1;
        private System.Windows.Forms.Label AJ_59354_lzwLabel3;
        private System.Windows.Forms.TextBox AJ_59354_lzwTextBox2;
        private System.Windows.Forms.Button AJ_59354_lzwButton2;
        private System.Windows.Forms.Button button1;
    }
}