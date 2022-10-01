namespace _59354_2_3
{
    partial class AJ_59354_form1
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
            this.AJ_59354_menuStrip = new System.Windows.Forms.MenuStrip();
            this.AJ_59354_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.AJ_59354_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AJ_59354_menuStrip
            // 
            this.AJ_59354_menuStrip.BackColor = System.Drawing.Color.Red;
            this.AJ_59354_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AJ_59354_toolStripMenuItem});
            this.AJ_59354_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.AJ_59354_menuStrip.Name = "AJ_59354_menuStrip";
            this.AJ_59354_menuStrip.Size = new System.Drawing.Size(214, 27);
            this.AJ_59354_menuStrip.TabIndex = 0;
            this.AJ_59354_menuStrip.Text = "Menu";
            // 
            // AJ_59354_toolStripMenuItem
            // 
            this.AJ_59354_toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.AJ_59354_toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AJ_59354_toolStripMenuItem.Name = "AJ_59354_toolStripMenuItem";
            this.AJ_59354_toolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.AJ_59354_toolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(283, 24);
            this.toolStripMenuItem2.Text = "Algorytm kompresji LZW";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.AJ_59354_MenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(283, 24);
            this.toolStripMenuItem3.Text = "Algorytm sortowania (bąbelkowe)";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.AJ_59354_sortItemClick);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(283, 24);
            this.toolStripMenuItem4.Text = "Algorytm matematyczny NWD";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.AJ_59354_clickItem3);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(283, 24);
            this.toolStripMenuItem5.Text = "Demo";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.AJ_59354_demoClick);
            // 
            // AJ_59354_form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(214, 111);
            this.Controls.Add(this.AJ_59354_menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.AJ_59354_menuStrip;
            this.MaximizeBox = false;
            this.Name = "AJ_59354_form1";
            this.ShowIcon = false;
            this.Text = "Projekt nr 3";
            this.AJ_59354_menuStrip.ResumeLayout(false);
            this.AJ_59354_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AJ_59354_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem AJ_59354_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}
