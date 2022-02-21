namespace ThreadPool
{
    partial class CarView
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
            this.PictureBoxCar = new System.Windows.Forms.PictureBox();
            this.LabelModel = new System.Windows.Forms.Label();
            this.LabelVendor = new System.Windows.Forms.Label();
            this.LabelYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxCar
            // 
            this.PictureBoxCar.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxCar.Name = "PictureBoxCar";
            this.PictureBoxCar.Size = new System.Drawing.Size(148, 150);
            this.PictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCar.TabIndex = 0;
            this.PictureBoxCar.TabStop = false;
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(154, 16);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(42, 13);
            this.LabelModel.TabIndex = 1;
            this.LabelModel.Text = "Model: ";
            // 
            // LabelVendor
            // 
            this.LabelVendor.AutoSize = true;
            this.LabelVendor.Location = new System.Drawing.Point(154, 64);
            this.LabelVendor.Name = "LabelVendor";
            this.LabelVendor.Size = new System.Drawing.Size(44, 13);
            this.LabelVendor.TabIndex = 2;
            this.LabelVendor.Text = "Vendor:";
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(154, 118);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(35, 13);
            this.LabelYear.TabIndex = 3;
            this.LabelYear.Text = "Year: ";
            // 
            // CarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.LabelVendor);
            this.Controls.Add(this.LabelModel);
            this.Controls.Add(this.PictureBoxCar);
            this.Name = "CarView";
            this.Size = new System.Drawing.Size(632, 150);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxCar;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.Label LabelVendor;
        private System.Windows.Forms.Label LabelYear;
    }
}
