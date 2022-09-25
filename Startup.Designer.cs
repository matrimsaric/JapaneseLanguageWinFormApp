namespace JapaneseLanguageWinForm
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bExit = new System.Windows.Forms.Button();
            this.bVerbSummary = new System.Windows.Forms.Button();
            this.bVerbDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(794, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 476);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Location = new System.Drawing.Point(1081, 574);
            this.bExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(82, 22);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bVerbSummary
            // 
            this.bVerbSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bVerbSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bVerbSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVerbSummary.ForeColor = System.Drawing.Color.White;
            this.bVerbSummary.Location = new System.Drawing.Point(10, 9);
            this.bVerbSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVerbSummary.Name = "bVerbSummary";
            this.bVerbSummary.Size = new System.Drawing.Size(770, 74);
            this.bVerbSummary.TabIndex = 2;
            this.bVerbSummary.Text = "Verb Summary";
            this.bVerbSummary.UseVisualStyleBackColor = false;
            this.bVerbSummary.Click += new System.EventHandler(this.bVerbSummary_Click);
            // 
            // bVerbDetail
            // 
            this.bVerbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bVerbDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bVerbDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVerbDetail.ForeColor = System.Drawing.Color.White;
            this.bVerbDetail.Location = new System.Drawing.Point(10, 88);
            this.bVerbDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVerbDetail.Name = "bVerbDetail";
            this.bVerbDetail.Size = new System.Drawing.Size(770, 74);
            this.bVerbDetail.TabIndex = 3;
            this.bVerbDetail.Text = "Verb Detail";
            this.bVerbDetail.UseVisualStyleBackColor = false;
            this.bVerbDetail.Click += new System.EventHandler(this.bVerbDetail_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.bVerbDetail);
            this.Controls.Add(this.bVerbSummary);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Startup";
            this.Text = "Japanese Language WinFormClient";
            this.Load += new System.EventHandler(this.Startup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button bExit;
        private Button bVerbSummary;
        private Button bVerbDetail;
    }
}