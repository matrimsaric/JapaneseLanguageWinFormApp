namespace JapaneseLanguageWinForm.GUI
{
    partial class VerbDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lKanji = new System.Windows.Forms.Label();
            this.lLine = new System.Windows.Forms.Label();
            this.lHiragana = new System.Windows.Forms.Label();
            this.lVerbType = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.InflectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kanji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiragana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lKanji
            // 
            this.lKanji.AutoSize = true;
            this.lKanji.Font = new System.Drawing.Font("Segoe UI", 82F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lKanji.Location = new System.Drawing.Point(12, 9);
            this.lKanji.Name = "lKanji";
            this.lKanji.Size = new System.Drawing.Size(370, 182);
            this.lKanji.TabIndex = 0;
            this.lKanji.Text = "Kanji";
            // 
            // lLine
            // 
            this.lLine.AutoSize = true;
            this.lLine.Font = new System.Drawing.Font("Segoe UI", 82F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lLine.Location = new System.Drawing.Point(527, 9);
            this.lLine.Name = "lLine";
            this.lLine.Size = new System.Drawing.Size(130, 182);
            this.lLine.TabIndex = 1;
            this.lLine.Text = "/";
            // 
            // lHiragana
            // 
            this.lHiragana.AutoSize = true;
            this.lHiragana.Font = new System.Drawing.Font("Segoe UI", 82F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHiragana.Location = new System.Drawing.Point(789, 19);
            this.lHiragana.Name = "lHiragana";
            this.lHiragana.Size = new System.Drawing.Size(624, 182);
            this.lHiragana.TabIndex = 2;
            this.lHiragana.Text = "Hiragana";
            // 
            // lVerbType
            // 
            this.lVerbType.AutoSize = true;
            this.lVerbType.Location = new System.Drawing.Point(1246, 214);
            this.lVerbType.Name = "lVerbType";
            this.lVerbType.Size = new System.Drawing.Size(70, 20);
            this.lVerbType.TabIndex = 3;
            this.lVerbType.Text = "VerbType";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InflectionName,
            this.TenseName,
            this.Kanji,
            this.Hiragana,
            this.Meaning});
            this.dgvDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetail.Location = new System.Drawing.Point(12, 255);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 29;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(1435, 399);
            this.dgvDetail.TabIndex = 4;
            // 
            // InflectionName
            // 
            this.InflectionName.DataPropertyName = "InflectionName";
            this.InflectionName.HeaderText = "Inflection";
            this.InflectionName.MinimumWidth = 6;
            this.InflectionName.Name = "InflectionName";
            this.InflectionName.ReadOnly = true;
            // 
            // TenseName
            // 
            this.TenseName.DataPropertyName = "TenseName";
            this.TenseName.HeaderText = "Tense";
            this.TenseName.MinimumWidth = 6;
            this.TenseName.Name = "TenseName";
            this.TenseName.ReadOnly = true;
            // 
            // Kanji
            // 
            this.Kanji.DataPropertyName = "Kanji";
            this.Kanji.HeaderText = "Kanji";
            this.Kanji.MinimumWidth = 6;
            this.Kanji.Name = "Kanji";
            this.Kanji.ReadOnly = true;
            // 
            // Hiragana
            // 
            this.Hiragana.DataPropertyName = "Hiragana";
            this.Hiragana.HeaderText = "Hiragana";
            this.Hiragana.MinimumWidth = 6;
            this.Hiragana.Name = "Hiragana";
            this.Hiragana.ReadOnly = true;
            // 
            // Meaning
            // 
            this.Meaning.DataPropertyName = "Meaning";
            this.Meaning.HeaderText = "Meaning";
            this.Meaning.MinimumWidth = 6;
            this.Meaning.Name = "Meaning";
            this.Meaning.ReadOnly = true;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(1353, 660);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(94, 29);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // VerbDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 701);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.lVerbType);
            this.Controls.Add(this.lHiragana);
            this.Controls.Add(this.lLine);
            this.Controls.Add(this.lKanji);
            this.Name = "VerbDetail";
            this.Text = "     ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lKanji;
        private Label lLine;
        private Label lHiragana;
        private Label lVerbType;
        private DataGridView dgvDetail;
        private Button bClose;
        private DataGridViewTextBoxColumn InflectionName;
        private DataGridViewTextBoxColumn TenseName;
        private DataGridViewTextBoxColumn Kanji;
        private DataGridViewTextBoxColumn Hiragana;
        private DataGridViewTextBoxColumn Meaning;
    }
}