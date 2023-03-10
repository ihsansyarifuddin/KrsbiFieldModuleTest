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
            this.fieldConfigurator2 = new KrsbiFieldModule.FieldConfigurator();
            this.SuspendLayout();
            // 
            // fieldConfigurator2
            // 
            this.fieldConfigurator2.Location = new System.Drawing.Point(12, 12);
            this.fieldConfigurator2.Name = "fieldConfigurator2";
            this.fieldConfigurator2.Size = new System.Drawing.Size(740, 492);
            this.fieldConfigurator2.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 512);
            this.Controls.Add(this.fieldConfigurator2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private KrsbiFieldModule.FieldConfigurator fieldConfigurator1;
        private KrsbiFieldModule.FieldConfigurator fieldConfigurator2;
    }
}