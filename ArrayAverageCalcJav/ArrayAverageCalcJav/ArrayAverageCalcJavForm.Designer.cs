namespace ArrayAverageCalcJav
{
    partial class frmArrayAverageCalcJav
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalcAverage = new System.Windows.Forms.Button();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(137)))), ((int)(((byte)(103)))));
            this.btnStart.Font = new System.Drawing.Font("Charlemagne Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(52, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 51);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Charlemagne Std", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAverage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAverage.Location = new System.Drawing.Point(99, 379);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(118, 25);
            this.lblAverage.TabIndex = 1;
            this.lblAverage.Text = "Average";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(137)))), ((int)(((byte)(103)))));
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(417, 24);
            this.mnuFile.TabIndex = 2;
            this.mnuFile.Text = "menuStrip1";
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 24;
            this.lstNumbers.Location = new System.Drawing.Point(205, 56);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(137, 268);
            this.lstNumbers.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(137)))), ((int)(((byte)(103)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Charlemagne Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // btnCalcAverage
            // 
            this.btnCalcAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(137)))), ((int)(((byte)(103)))));
            this.btnCalcAverage.Font = new System.Drawing.Font("Charlemagne Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcAverage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcAverage.Location = new System.Drawing.Point(12, 255);
            this.btnCalcAverage.Name = "btnCalcAverage";
            this.btnCalcAverage.Size = new System.Drawing.Size(172, 69);
            this.btnCalcAverage.TabIndex = 4;
            this.btnCalcAverage.Text = "Calculate Average";
            this.btnCalcAverage.UseVisualStyleBackColor = false;
            this.btnCalcAverage.Click += new System.EventHandler(this.btnCalcAverage_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // frmArrayAverageCalcJav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(137)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(417, 446);
            this.Controls.Add(this.btnCalcAverage);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmArrayAverageCalcJav";
            this.Text = "Average Array Calculator by Javiera Diaz";
            this.Load += new System.EventHandler(this.frmArrayAverageCalcJav_Load);
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnCalcAverage;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

