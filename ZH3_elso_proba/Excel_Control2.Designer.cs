namespace ZH3_elso_proba
{
    partial class Excel_Control2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Excel_label = new System.Windows.Forms.Label();
            this.Import_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Excel_label
            // 
            this.Excel_label.AutoSize = true;
            this.Excel_label.Location = new System.Drawing.Point(54, 68);
            this.Excel_label.Name = "Excel_label";
            this.Excel_label.Size = new System.Drawing.Size(326, 20);
            this.Excel_label.TabIndex = 0;
            this.Excel_label.Text = "Szeretnéd kiimportálni az Vevők táblát excelbe?";
            // 
            // Import_button
            // 
            this.Import_button.Location = new System.Drawing.Point(54, 134);
            this.Import_button.Name = "Import_button";
            this.Import_button.Size = new System.Drawing.Size(94, 29);
            this.Import_button.TabIndex = 1;
            this.Import_button.Text = "Naná!";
            this.Import_button.UseVisualStyleBackColor = true;
            this.Import_button.Click += new System.EventHandler(this.Import_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "A tábla adatai ezek lesznek:";
            // 
            // Excel_Control2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Import_button);
            this.Controls.Add(this.Excel_label);
            this.Name = "Excel_Control2";
            this.Size = new System.Drawing.Size(752, 492);
            this.Load += new System.EventHandler(this.Excel_Control2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Excel_label;
        private Button Import_button;
        private Label label1;
    }
}
