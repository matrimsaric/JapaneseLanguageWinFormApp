using JapaneseLanguageWinForm.DataLibaryAccess;
using LanguageConsult.DataAccess;
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
    
    public partial class VerbSearchDialogue : Form
    {
        public Guid chosenGuid;
        public VerbSearchDialogue()
        {
            InitializeComponent();

            this.LoadAll();
        }

        private void LoadAll()
        {
            // TODO Add restrictions on verb type/ search/ validity to call both ends..
            Task<DataTable> verbsToUse = DataControlSingleton.GetDataAccess().LoadAllVerbs();

            if(verbsToUse.Result != null)
            {
                dgvVerbs.DataSource = verbsToUse.Result;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvVerbs_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvVerbs.SelectedRows.Count > 0)
            {
                bAccept.Enabled = true;
            }
            else
            {
                bAccept.Enabled = false;
            }
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            DataGridViewRow row = this.dgvVerbs.Rows[dgvVerbs.SelectedRows[0].Index];

            chosenGuid = (Guid)row.Cells["VerbId"].Value;
            this.Close();
        }

        private void dgvVerbs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // select this row
            this.DialogResult = DialogResult.OK;
            DataGridViewRow row = this.dgvVerbs.Rows[dgvVerbs.SelectedRows[0].Index];

            chosenGuid = (Guid)row.Cells["VerbId"].Value;
            this.Close();
        }

        private void bFilterResults_Click(object sender, EventArgs e)
        {
            int verbChoice = 0;
            if (rbIchidan.Checked == true) verbChoice = 1;
            else if (rbGodan.Checked == true) verbChoice = 2;
            else if (rbException.Checked == true) verbChoice = 3;



            Task<DataTable> verbsToUse = DataControlSingleton.GetDataAccess().LoadFilteredVerbs(verbChoice, ddlFilterChoice.SelectedIndex, tbSearchText.Text);

            if (verbsToUse.Result != null)
            {
                dgvVerbs.DataSource = verbsToUse.Result;
            }
        }
    }
}
