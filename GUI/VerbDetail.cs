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
        }
    }
}
