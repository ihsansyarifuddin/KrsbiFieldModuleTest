namespace KrsbiFieldModuleTest
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
            this.fieldConfigurator1 = new KrsbiFieldModule.FieldConfigurator();
            this.SuspendLayout();
            // 
            // fieldConfigurator1
            // 
            this.fieldConfigurator1.Location = new System.Drawing.Point(13, 13);
            this.fieldConfigurator1.Name = "fieldConfigurator1";
            this.fieldConfigurator1.Size = new System.Drawing.Size(740, 449);
            this.fieldConfigurator1.TabIndex = 0;
            this.fieldConfigurator1.Load += new System.EventHandler(this.fieldConfigurator1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 472);
            this.Controls.Add(this.fieldConfigurator1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private KrsbiFieldModule.FieldConfigurator fieldConfigurator1;
    }
}