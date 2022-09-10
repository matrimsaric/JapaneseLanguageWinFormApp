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
        private DataAccess dataAccessLayer;
        public Guid chosenGuid;
        public VerbSearchDialogue(DataAccess dataAccessLayerToUse)
        {
            InitializeComponent();
            this.dataAccessLayer = dataAccessLayerToUse;

            this.LoadAll();
        }

        private void LoadAll()
        {
            // TODO Add restrictions on verb type/ search/ validity to call both ends..
            Task<DataTable> verbsToUse = dataAccessLayer.LoadAllVerbs();

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
    }
}
