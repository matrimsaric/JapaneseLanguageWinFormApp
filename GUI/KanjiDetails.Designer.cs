namespace JapaneseLanguageWinForm.GUI
{
    partial class KanjiDetails
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
            this.bClose = new System.Windows.Forms.Button();
            this.pbKanjiLines = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKanjiLines)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(1456, 324);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // pbKanjiLines
            // 
            this.pbKanjiLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbKanjiLines.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbKanjiLines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbKanjiLines.Location = new System.Drawing.Point(12, 12);
            this.pbKanjiLines.Name = "pbKanjiLines";
            this.pbKanjiLines.Size = new System.Drawing.Size(1519, 306);
            this.pbKanjiLines.TabIndex = 1;
            this.pbKanjiLines.TabStop = false;
            // 
            // KanjiDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 356);
            this.Controls.Add(this.pbKanjiLines);
            this.Controls.Add(this.bClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "KanjiDetails";
            this.Text = "KanjiDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pbKanjiLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bClose;
        private PictureBox pbKanjiLines;
    }
}