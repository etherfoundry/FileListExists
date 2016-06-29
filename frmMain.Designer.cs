namespace FileListExists
{
    partial class frmMain
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExists = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoesntExist = new System.Windows.Forms.TextBox();
            this.cmdRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(12, 33);
            this.txtSource.MaxLength = 3276700;
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(249, 524);
            this.txtSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exists:";
            // 
            // txtExists
            // 
            this.txtExists.Location = new System.Drawing.Point(267, 33);
            this.txtExists.Multiline = true;
            this.txtExists.Name = "txtExists";
            this.txtExists.ReadOnly = true;
            this.txtExists.Size = new System.Drawing.Size(249, 524);
            this.txtExists.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doesn\'t Exist:";
            // 
            // txtDoesntExist
            // 
            this.txtDoesntExist.Location = new System.Drawing.Point(522, 33);
            this.txtDoesntExist.Multiline = true;
            this.txtDoesntExist.Name = "txtDoesntExist";
            this.txtDoesntExist.ReadOnly = true;
            this.txtDoesntExist.Size = new System.Drawing.Size(249, 524);
            this.txtDoesntExist.TabIndex = 4;
            // 
            // cmdRun
            // 
            this.cmdRun.Location = new System.Drawing.Point(694, 563);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(75, 23);
            this.cmdRun.TabIndex = 6;
            this.cmdRun.Text = "Run";
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 600);
            this.Controls.Add(this.cmdRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoesntExist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Name = "frmMain";
            this.Text = "File Lists Exists - Garrett\'s App Collection ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExists;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoesntExist;
        private System.Windows.Forms.Button cmdRun;
    }
}

