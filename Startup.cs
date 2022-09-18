using JapaneseLanguageWinForm.DataLibaryAccess;
using JapaneseLanguageWinForm.GUI;

namespace JapaneseLanguageWinForm
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();

            // ensure data access is generated
        }

      
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Startup_Load(object sender, EventArgs e)
        {

        }

        private void bVerbSummary_Click(object sender, EventArgs e)
        {
            VerbSummary newSummaryWindow = new VerbSummary();
            newSummaryWindow.ShowDialog(this);
        }

        private void bVerbDetail_Click(object sender, EventArgs e)
        {
            VerbDetail newDetailWindow = new VerbDetail();
            newDetailWindow.ShowDialog(this);
        }
    }
}