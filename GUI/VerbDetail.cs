using LanguageConsult.Verbs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLanguageWinForm.GUI
{
    public partial class VerbDetail : Form
    {
        private Verb liveVerb;
        public VerbDetail()
        {
            InitializeComponent();
        }

        public VerbDetail(Verb verbToShow)
        {
            liveVerb = verbToShow;
            InitializeComponent();

            lKanji.Text = liveVerb.Kanji;
            lHiragana.Text = liveVerb.Hiragana;
            lKanji.ForeColor = liveVerb.verbColor;
            lHiragana.ForeColor = liveVerb.verbColor;
            lVerbType.Text = liveVerb.verbString;
            lLine.ForeColor = liveVerb.verbColor;
            lVerbType.ForeColor = liveVerb.verbColor;

            GetData();
            
        }

       

        private void GetData()
        {
            DataTable data = liveVerb.GetVerbAsDataTable(liveVerb.inflections);

            if(data != null)
            {
                dgvDetail.AutoGenerateColumns = true;// prevent columns duplication
                dgvDetail.DataSource = data;
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
