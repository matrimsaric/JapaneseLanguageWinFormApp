namespace JapaneseLanguageWinForm.GUI
{
    partial class VerbSummary
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
            this.tbVerbId = new System.Windows.Forms.TextBox();
            this.tbKanji = new System.Windows.Forms.TextBox();
            this.tbHiragana = new System.Windows.Forms.TextBox();
            this.tbRomaji = new System.Windows.Forms.TextBox();
            this.tbKanjiCharacter = new System.Windows.Forms.TextBox();
            this.tbMeaning = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbInflections = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTenses = new System.Windows.Forms.ListBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.rbIchidan = new System.Windows.Forms.RadioButton();
            this.rbGodan = new System.Windows.Forms.RadioButton();
            this.rbException = new System.Windows.Forms.RadioButton();
            this.llKanjiCharacter = new System.Windows.Forms.LinkLabel();
            this.bLookup = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbVerbId
            // 
            this.tbVerbId.Location = new System.Drawing.Point(123, 12);
            this.tbVerbId.Name = "tbVerbId";
            this.tbVerbId.ReadOnly = true;
            this.tbVerbId.Size = new System.Drawing.Size(370, 27);
            this.tbVerbId.TabIndex = 0;
            // 
            // tbKanji
            // 
            this.tbKanji.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKanji.Location = new System.Drawing.Point(123, 49);
            this.tbKanji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKanji.Name = "tbKanji";
            this.tbKanji.Size = new System.Drawing.Size(559, 78);
            this.tbKanji.TabIndex = 2;
            this.tbKanji.TextChanged += new System.EventHandler(this.tbEnableSave);
            // 
            // tbHiragana
            // 
            this.tbHiragana.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHiragana.Location = new System.Drawing.Point(123, 143);
            this.tbHiragana.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHiragana.Name = "tbHiragana";
            this.tbHiragana.Size = new System.Drawing.Size(559, 78);
            this.tbHiragana.TabIndex = 3;
            this.tbHiragana.TextChanged += new System.EventHandler(this.tbEnableSave);
            // 
            // tbRomaji
            // 
            this.tbRomaji.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRomaji.Location = new System.Drawing.Point(123, 236);
            this.tbRomaji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRomaji.Name = "tbRomaji";
            this.tbRomaji.Size = new System.Drawing.Size(559, 34);
            this.tbRomaji.TabIndex = 4;
            this.tbRomaji.TextChanged += new System.EventHandler(this.tbEnableSave);
            // 
            // tbKanjiCharacter
            // 
            this.tbKanjiCharacter.Font = new System.Drawing.Font("Segoe UI", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKanjiCharacter.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tbKanjiCharacter.Location = new System.Drawing.Point(861, 49);
            this.tbKanjiCharacter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKanjiCharacter.Name = "tbKanjiCharacter";
            this.tbKanjiCharacter.Size = new System.Drawing.Size(502, 220);
            this.tbKanjiCharacter.TabIndex = 5;
            this.tbKanjiCharacter.TextChanged += new System.EventHandler(this.tbEnableSave);
            // 
            // tbMeaning
            // 
            this.tbMeaning.Location = new System.Drawing.Point(123, 295);
            this.tbMeaning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMeaning.Name = "tbMeaning";
            this.tbMeaning.Size = new System.Drawing.Size(1077, 27);
            this.tbMeaning.TabIndex = 6;
            this.tbMeaning.TextChanged += new System.EventHandler(this.tbEnableSave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kanji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hiragana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Romaji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Meaning";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Inflections";
            // 
            // lbInflections
            // 
            this.lbInflections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInflections.FormattingEnabled = true;
            this.lbInflections.ItemHeight = 20;
            this.lbInflections.Location = new System.Drawing.Point(123, 388);
            this.lbInflections.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbInflections.Name = "lbInflections";
            this.lbInflections.Size = new System.Drawing.Size(559, 464);
            this.lbInflections.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(713, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tenses";
            // 
            // lbTenses
            // 
            this.lbTenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTenses.FormattingEnabled = true;
            this.lbTenses.ItemHeight = 20;
            this.lbTenses.Location = new System.Drawing.Point(717, 388);
            this.lbTenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTenses.Name = "lbTenses";
            this.lbTenses.Size = new System.Drawing.Size(484, 464);
            this.lbTenses.TabIndex = 15;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(1278, 916);
            this.bCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(86, 31);
            this.bCancel.TabIndex = 20;
            this.bCancel.Text = "Close";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(1185, 916);
            this.bClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(86, 31);
            this.bClear.TabIndex = 21;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Enabled = false;
            this.bDelete.Location = new System.Drawing.Point(1093, 916);
            this.bDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(86, 31);
            this.bDelete.TabIndex = 22;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Enabled = false;
            this.bSave.Location = new System.Drawing.Point(1000, 916);
            this.bSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(86, 31);
            this.bSave.TabIndex = 23;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // rbIchidan
            // 
            this.rbIchidan.AutoSize = true;
            this.rbIchidan.Location = new System.Drawing.Point(576, 12);
            this.rbIchidan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbIchidan.Name = "rbIchidan";
            this.rbIchidan.Size = new System.Drawing.Size(78, 24);
            this.rbIchidan.TabIndex = 24;
            this.rbIchidan.Text = "Ichidan";
            this.rbIchidan.UseVisualStyleBackColor = true;
            // 
            // rbGodan
            // 
            this.rbGodan.AutoSize = true;
            this.rbGodan.Checked = true;
            this.rbGodan.Location = new System.Drawing.Point(656, 12);
            this.rbGodan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbGodan.Name = "rbGodan";
            this.rbGodan.Size = new System.Drawing.Size(74, 24);
            this.rbGodan.TabIndex = 25;
            this.rbGodan.TabStop = true;
            this.rbGodan.Text = "Godan";
            this.rbGodan.UseVisualStyleBackColor = true;
            // 
            // rbException
            // 
            this.rbException.AutoSize = true;
            this.rbException.Location = new System.Drawing.Point(747, 13);
            this.rbException.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbException.Name = "rbException";
            this.rbException.Size = new System.Drawing.Size(95, 24);
            this.rbException.TabIndex = 26;
            this.rbException.Text = "Exception";
            this.rbException.UseVisualStyleBackColor = true;
            // 
            // llKanjiCharacter
            // 
            this.llKanjiCharacter.AutoSize = true;
            this.llKanjiCharacter.Location = new System.Drawing.Point(717, 49);
            this.llKanjiCharacter.Name = "llKanjiCharacter";
            this.llKanjiCharacter.Size = new System.Drawing.Size(109, 20);
            this.llKanjiCharacter.TabIndex = 27;
            this.llKanjiCharacter.TabStop = true;
            this.llKanjiCharacter.Text = "Kanji Character";
            // 
            // bLookup
            // 
            this.bLookup.Location = new System.Drawing.Point(501, 13);
            this.bLookup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bLookup.Name = "bLookup";
            this.bLookup.Size = new System.Drawing.Size(48, 31);
            this.bLookup.TabIndex = 28;
            this.bLookup.Text = "?";
            this.bLookup.UseVisualStyleBackColor = true;
            this.bLookup.Click += new System.EventHandler(this.bLookup_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 20);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Verb Id";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // VerbSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 963);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bLookup);
            this.Controls.Add(this.llKanjiCharacter);
            this.Controls.Add(this.rbException);
            this.Controls.Add(this.rbGodan);
            this.Controls.Add(this.rbIchidan);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.lbTenses);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbInflections);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMeaning);
            this.Controls.Add(this.tbKanjiCharacter);
            this.Controls.Add(this.tbRomaji);
            this.Controls.Add(this.tbHiragana);
            this.Controls.Add(this.tbKanji);
            this.Controls.Add(this.tbVerbId);
            this.Name = "VerbSummary";
            this.Text = "Verb Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbVerbId;
        private TextBox tbKanji;
        private TextBox tbHiragana;
        private TextBox tbRomaji;
        private TextBox tbKanjiCharacter;
        private TextBox tbMeaning;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private ListBox lbInflections;
        private Label label8;
        private ListBox lbTenses;
        private Button bCancel;
        private Button bClear;
        private Button bDelete;
        private Button bSave;
        private RadioButton rbIchidan;
        private RadioButton rbGodan;
        private RadioButton rbException;
        private LinkLabel llKanjiCharacter;
        private Button bLookup;
        private LinkLabel linkLabel1;
    }
}