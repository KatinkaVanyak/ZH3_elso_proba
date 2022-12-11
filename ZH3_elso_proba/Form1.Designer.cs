namespace ZH3_elso_proba
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
            this.button_Adatbazishoz = new System.Windows.Forms.Button();
            this.button_Excelhez = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_Adatbazishoz
            // 
            this.button_Adatbazishoz.Location = new System.Drawing.Point(12, 29);
            this.button_Adatbazishoz.Name = "button_Adatbazishoz";
            this.button_Adatbazishoz.Size = new System.Drawing.Size(100, 48);
            this.button_Adatbazishoz.TabIndex = 0;
            this.button_Adatbazishoz.Text = "Adatbázis";
            this.button_Adatbazishoz.UseVisualStyleBackColor = true;
            this.button_Adatbazishoz.Click += new System.EventHandler(this.button_Adatbazishoz_Click);
            // 
            // button_Excelhez
            // 
            this.button_Excelhez.Location = new System.Drawing.Point(12, 103);
            this.button_Excelhez.Name = "button_Excelhez";
            this.button_Excelhez.Size = new System.Drawing.Size(100, 50);
            this.button_Excelhez.TabIndex = 1;
            this.button_Excelhez.Text = "Excel export";
            this.button_Excelhez.UseVisualStyleBackColor = true;
            this.button_Excelhez.Click += new System.EventHandler(this.button_Excelhez_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(118, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 491);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Excelhez);
            this.Controls.Add(this.button_Adatbazishoz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Adatbazishoz;
        private Button button_Excelhez;
        public Panel panel1;
    }
}