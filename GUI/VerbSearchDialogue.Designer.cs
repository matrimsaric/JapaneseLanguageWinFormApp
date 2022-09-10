namespace JapaneseLanguageWinForm.GUI
{
    partial class VerbSearchDialogue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbIchidan = new System.Windows.Forms.RadioButton();
            this.rbGodan = new System.Windows.Forms.RadioButton();
            this.rbException = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.cbException = new System.Windows.Forms.CheckBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.dgvVerbs = new System.Windows.Forms.DataGridView();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbs)).BeginInit();
            this.SuspendLayout();
            // 
            // rbIchidan
            // 
            this.rbIchidan.AutoSize = true;
            this.rbIchidan.Location = new System.Drawing.Point(87, 14);
            this.rbIchidan.Name = "rbIchidan";
            this.rbIchidan.Size = new System.Drawing.Size(64, 19);
            this.rbIchidan.TabIndex = 0;
            this.rbIchidan.Text = "Ichidan";
            this.rbIchidan.UseVisualStyleBackColor = true;
            // 
            // rbGodan
            // 
            this.rbGodan.AutoSize = true;
            this.rbGodan.Location = new System.Drawing.Point(157, 14);
            this.rbGodan.Name = "rbGodan";
            this.rbGodan.Size = new System.Drawing.Size(60, 19);
            this.rbGodan.TabIndex = 1;
            this.rbGodan.Text = "Godan";
            this.rbGodan.UseVisualStyleBackColor = true;
            // 
            // rbException
            // 
            this.rbException.AutoSize = true;
            this.rbException.Location = new System.Drawing.Point(223, 14);
            this.rbException.Name = "rbException";
            this.rbException.Size = new System.Drawing.Size(77, 19);
            this.rbException.TabIndex = 2;
            this.rbException.Text = "Exception";
            this.rbException.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kanji",
            "Hiragana",
            "Romaji",
            "Meaning"});
            this.comboBox1.Location = new System.Drawing.Point(12, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(230, 48);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(422, 23);
            this.tbSearchText.TabIndex = 4;
            // 
            // cbException
            // 
            this.cbException.AutoSize = true;
            this.cbException.Location = new System.Drawing.Point(230, 77);
            this.cbException.Name = "cbException";
            this.cbException.Size = new System.Drawing.Size(114, 19);
            this.cbException.TabIndex = 5;
            this.cbException.Text = "Incomplete Only";
            this.cbException.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(30, 14);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(39, 19);
            this.rbAll.TabIndex = 6;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // dgvVerbs
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvVerbs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVerbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerbs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerbs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVerbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbs.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvVerbs.Location = new System.Drawing.Point(12, 102);
            this.dgvVerbs.MultiSelect = false;
            this.dgvVerbs.Name = "dgvVerbs";
            this.dgvVerbs.ReadOnly = true;
            this.dgvVerbs.RowTemplate.Height = 25;
            this.dgvVerbs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerbs.Size = new System.Drawing.Size(776, 305);
            this.dgvVerbs.TabIndex = 7;
            this.dgvVerbs.SelectionChanged += new System.EventHandler(this.dgvVerbs_SelectionChanged);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(713, 415);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAccept.Enabled = false;
            this.bAccept.Location = new System.Drawing.Point(632, 415);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 23);
            this.bAccept.TabIndex = 9;
            this.bAccept.Text = "Select";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // VerbSearchDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dgvVerbs);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.cbException);
            this.Controls.Add(this.tbSearchText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbException);
            this.Controls.Add(this.rbGodan);
            this.Controls.Add(this.rbIchidan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VerbSearchDialogue";
            this.Text = "VerbSearchDialogue";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbIchidan;
        private RadioButton rbGodan;
        private RadioButton rbException;
        private ComboBox comboBox1;
        private TextBox tbSearchText;
        private CheckBox cbException;
        private RadioButton rbAll;
        private DataGridView dgvVerbs;
        private Button bCancel;
        private Button bAccept;
    }
}