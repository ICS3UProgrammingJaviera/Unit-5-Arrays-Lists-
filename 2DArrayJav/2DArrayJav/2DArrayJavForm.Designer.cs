namespace _2DArrayJav
{
    partial class frm2DArrayJav
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
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEnterLength = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblEnterWidth = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.txtArray = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // nudLength
            // 
            this.nudLength.Font = new System.Drawing.Font("Chaparral Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLength.Location = new System.Drawing.Point(196, 82);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 27);
            this.nudLength.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(176)))), ((int)(((byte)(116)))));
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(469, 27);
            this.mnuFile.TabIndex = 1;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Chaparral Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(105, 24);
            this.mniExit.Text = "Exit";
            // 
            // lblEnterLength
            // 
            this.lblEnterLength.AutoSize = true;
            this.lblEnterLength.Font = new System.Drawing.Font("Chaparral Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterLength.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterLength.Location = new System.Drawing.Point(91, 80);
            this.lblEnterLength.Name = "lblEnterLength";
            this.lblEnterLength.Size = new System.Drawing.Size(73, 25);
            this.lblEnterLength.TabIndex = 2;
            this.lblEnterLength.Text = "Length";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Chaparral Pro", 15.75F);
            this.btnCreate.Location = new System.Drawing.Point(174, 202);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(97, 38);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblEnterWidth
            // 
            this.lblEnterWidth.AutoSize = true;
            this.lblEnterWidth.Font = new System.Drawing.Font("Chaparral Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterWidth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterWidth.Location = new System.Drawing.Point(98, 141);
            this.lblEnterWidth.Name = "lblEnterWidth";
            this.lblEnterWidth.Size = new System.Drawing.Size(66, 25);
            this.lblEnterWidth.TabIndex = 5;
            this.lblEnterWidth.Text = "Width";
            // 
            // nudWidth
            // 
            this.nudWidth.Font = new System.Drawing.Font("Chaparral Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWidth.Location = new System.Drawing.Point(196, 141);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 27);
            this.nudWidth.TabIndex = 6;
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(96, 267);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(257, 191);
            this.txtArray.TabIndex = 7;
            // 
            // frm2DArrayJav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(176)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(469, 492);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.lblEnterWidth);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblEnterLength);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frm2DArrayJav";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblEnterLength;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblEnterWidth;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.TextBox txtArray;
    }
}

