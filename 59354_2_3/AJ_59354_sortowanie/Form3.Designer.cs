
namespace _59354_2_3.AJ_59354_sortowanie
{
    partial class AJ_59354_bubbleForm
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
            this.AJ_59354_bubbleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AJ_59354_bubbleLabel1 = new System.Windows.Forms.Label();
            this.AJ_59354_bubbleLabel2 = new System.Windows.Forms.Label();
            this.AJ_59354_bubbleLabel3 = new System.Windows.Forms.Label();
            this.AJ_59354_bubbleTextBox1 = new System.Windows.Forms.TextBox();
            this.AJ_59354_bubbleButton1 = new System.Windows.Forms.Button();
            this.AJ_59354_bubbleTextBox2 = new System.Windows.Forms.TextBox();
            this.AJ_59354_bubbleButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AJ_59354_bubbleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AJ_59354_bubbleNumericUpDown
            // 
            this.AJ_59354_bubbleNumericUpDown.Location = new System.Drawing.Point(223, 7);
            this.AJ_59354_bubbleNumericUpDown.Name = "AJ_59354_bubbleNumericUpDown";
            this.AJ_59354_bubbleNumericUpDown.Size = new System.Drawing.Size(46, 23);
            this.AJ_59354_bubbleNumericUpDown.TabIndex = 0;
            // 
            // AJ_59354_bubbleLabel1
            // 
            this.AJ_59354_bubbleLabel1.AutoSize = true;
            this.AJ_59354_bubbleLabel1.Location = new System.Drawing.Point(12, 9);
            this.AJ_59354_bubbleLabel1.Name = "AJ_59354_bubbleLabel1";
            this.AJ_59354_bubbleLabel1.Size = new System.Drawing.Size(135, 15);
            this.AJ_59354_bubbleLabel1.TabIndex = 1;
            this.AJ_59354_bubbleLabel1.Text = "Podaj ilość liczb w ciągu";
            // 
            // AJ_59354_bubbleLabel2
            // 
            this.AJ_59354_bubbleLabel2.AutoSize = true;
            this.AJ_59354_bubbleLabel2.Location = new System.Drawing.Point(13, 28);
            this.AJ_59354_bubbleLabel2.Name = "AJ_59354_bubbleLabel2";
            this.AJ_59354_bubbleLabel2.Size = new System.Drawing.Size(175, 15);
            this.AJ_59354_bubbleLabel2.TabIndex = 2;
            this.AJ_59354_bubbleLabel2.Text = "ciąg będzie generowany losowo";
            // 
            // AJ_59354_bubbleLabel3
            // 
            this.AJ_59354_bubbleLabel3.AutoSize = true;
            this.AJ_59354_bubbleLabel3.Location = new System.Drawing.Point(12, 47);
            this.AJ_59354_bubbleLabel3.Name = "AJ_59354_bubbleLabel3";
            this.AJ_59354_bubbleLabel3.Size = new System.Drawing.Size(31, 15);
            this.AJ_59354_bubbleLabel3.TabIndex = 3;
            this.AJ_59354_bubbleLabel3.Text = "Ciąg";
            // 
            // AJ_59354_bubbleTextBox1
            // 
            this.AJ_59354_bubbleTextBox1.Location = new System.Drawing.Point(50, 47);
            this.AJ_59354_bubbleTextBox1.Name = "AJ_59354_bubbleTextBox1";
            this.AJ_59354_bubbleTextBox1.Size = new System.Drawing.Size(219, 23);
            this.AJ_59354_bubbleTextBox1.TabIndex = 4;
            // 
            // AJ_59354_bubbleButton1
            // 
            this.AJ_59354_bubbleButton1.AutoSize = true;
            this.AJ_59354_bubbleButton1.Location = new System.Drawing.Point(53, 93);
            this.AJ_59354_bubbleButton1.Name = "AJ_59354_bubbleButton1";
            this.AJ_59354_bubbleButton1.Size = new System.Drawing.Size(97, 25);
            this.AJ_59354_bubbleButton1.TabIndex = 5;
            this.AJ_59354_bubbleButton1.Text = "Generuj i sortuj";
            this.AJ_59354_bubbleButton1.UseVisualStyleBackColor = true;
            this.AJ_59354_bubbleButton1.Click += new System.EventHandler(this.AJ_59354_genAndSortClick);
            // 
            // AJ_59354_bubbleTextBox2
            // 
            this.AJ_59354_bubbleTextBox2.Location = new System.Drawing.Point(50, 140);
            this.AJ_59354_bubbleTextBox2.Name = "AJ_59354_bubbleTextBox2";
            this.AJ_59354_bubbleTextBox2.Size = new System.Drawing.Size(219, 23);
            this.AJ_59354_bubbleTextBox2.TabIndex = 6;
            // 
            // AJ_59354_bubbleButton2
            // 
            this.AJ_59354_bubbleButton2.Location = new System.Drawing.Point(194, 93);
            this.AJ_59354_bubbleButton2.Name = "AJ_59354_bubbleButton2";
            this.AJ_59354_bubbleButton2.Size = new System.Drawing.Size(75, 23);
            this.AJ_59354_bubbleButton2.TabIndex = 7;
            this.AJ_59354_bubbleButton2.Text = "Reset";
            this.AJ_59354_bubbleButton2.UseVisualStyleBackColor = true;
            this.AJ_59354_bubbleButton2.Click += new System.EventHandler(this.AJ_59354_reset);
            // 
            // AJ_59354_bubbleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 242);
            this.Controls.Add(this.AJ_59354_bubbleButton2);
            this.Controls.Add(this.AJ_59354_bubbleTextBox2);
            this.Controls.Add(this.AJ_59354_bubbleButton1);
            this.Controls.Add(this.AJ_59354_bubbleTextBox1);
            this.Controls.Add(this.AJ_59354_bubbleLabel3);
            this.Controls.Add(this.AJ_59354_bubbleLabel2);
            this.Controls.Add(this.AJ_59354_bubbleLabel1);
            this.Controls.Add(this.AJ_59354_bubbleNumericUpDown);
            this.MaximizeBox = false;
            this.Name = "AJ_59354_bubbleForm";
            this.ShowIcon = false;
            this.Text = "Aglorytm sortowania Bubble";
            ((System.ComponentModel.ISupportInitialize)(this.AJ_59354_bubbleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AJ_59354_bubbleNumericUpDown;
        private System.Windows.Forms.Label AJ_59354_bubbleLabel1;
        private System.Windows.Forms.Label AJ_59354_bubbleLabel2;
        private System.Windows.Forms.Label AJ_59354_bubbleLabel3;
        private System.Windows.Forms.TextBox AJ_59354_bubbleTextBox1;
        private System.Windows.Forms.Button AJ_59354_bubbleButton1;
        private System.Windows.Forms.TextBox AJ_59354_bubbleTextBox2;
        private System.Windows.Forms.Button AJ_59354_bubbleButton2;
    }
}