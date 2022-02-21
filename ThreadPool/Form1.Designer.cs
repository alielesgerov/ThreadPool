namespace ThreadPool
{
    partial class Form1
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
            this.CheckBoxSingle = new System.Windows.Forms.CheckBox();
            this.CheckBoxMulti = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBoxSingle
            // 
            this.CheckBoxSingle.AutoSize = true;
            this.CheckBoxSingle.Location = new System.Drawing.Point(13, 424);
            this.CheckBoxSingle.Name = "CheckBoxSingle";
            this.CheckBoxSingle.Size = new System.Drawing.Size(55, 17);
            this.CheckBoxSingle.TabIndex = 0;
            this.CheckBoxSingle.Text = "Single";
            this.CheckBoxSingle.UseVisualStyleBackColor = true;
            this.CheckBoxSingle.CheckedChanged += new System.EventHandler(this.CheckBoxSingle_CheckedChanged);
            // 
            // CheckBoxMulti
            // 
            this.CheckBoxMulti.AutoSize = true;
            this.CheckBoxMulti.Location = new System.Drawing.Point(73, 424);
            this.CheckBoxMulti.Name = "CheckBoxMulti";
            this.CheckBoxMulti.Size = new System.Drawing.Size(48, 17);
            this.CheckBoxMulti.TabIndex = 1;
            this.CheckBoxMulti.Text = "Multi";
            this.CheckBoxMulti.UseVisualStyleBackColor = true;
            this.CheckBoxMulti.CheckedChanged += new System.EventHandler(this.CheckBoxMulti_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 399);
            this.panel1.TabIndex = 2;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(713, 420);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(632, 420);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Location = new System.Drawing.Point(270, 427);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(36, 13);
            this.LabelTimer.TabIndex = 6;
            this.LabelTimer.Text = "Time: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.LabelTimer);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckBoxMulti);
            this.Controls.Add(this.CheckBoxSingle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxSingle;
        private System.Windows.Forms.CheckBox CheckBoxMulti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelTimer;
    }
}

