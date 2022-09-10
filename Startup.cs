using JapaneseLanguageWinForm.GUI;

namespace JapaneseLanguageWinForm
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
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
    }
}