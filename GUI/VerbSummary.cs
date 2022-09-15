using LanguageConsult.DataAccess;
using LanguageConsult.DataAccess.MSSqlDataAccess;
using LanguageConsult.Verbs;
using LanguageConsult.Verbs.InflectionControl;
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
    
    public partial class VerbSummary : Form
    {
        private Verb controlVerb;
        private bool newVerb = true;
        private DataAccess dataAccessLayer;
        public VerbSummary()
        {
            InitializeComponent();

            DataAccessProvider prov = new DataAccessProvider();
            dataAccessLayer = prov.GetLiveDataAccess();
            lbInflections.DrawMode = DrawMode.OwnerDrawFixed;
            lbInflections.DrawItem += new DrawItemEventHandler(lbDrawInflection);
            lbTenses.DrawMode = DrawMode.OwnerDrawFixed;
            lbTenses.DrawItem += new DrawItemEventHandler(lbDrawTense);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLookup_Click(object sender, EventArgs e)
        {
            VerbSearchDialogue searcher = new VerbSearchDialogue(dataAccessLayer);
 
            DialogResult result = searcher.ShowDialog(this);

            if(result == DialogResult.OK)
            {
                Guid newGuid = searcher.chosenGuid;
                tbVerbId.Text = newGuid.ToString();

                LoadVerb(newGuid);
            }
        }

        private void LoadVerb(Guid targetId)
        {
            Task<Verb> loadedVerb = dataAccessLayer.LoadSpecificVerb(targetId);

            if(loadedVerb.Result != null)
            {
                controlVerb = loadedVerb.Result;
                tbKanji.Text = controlVerb.Kanji;
                tbHiragana.Text = controlVerb.Hiragana;
                tbRomaji.Text = controlVerb.Romaji;
                tbMeaning.Text = controlVerb.Meaning;
                tbKanjiCharacter.Text = controlVerb.KanjiCharacter;

                switch (controlVerb.verbType)
                {
                    case VERB_TYPE.ICHIDAN:
                        rbIchidan.Checked = true;
                        break;
                    case VERB_TYPE.EXCEPTION:
                        rbException.Checked = true;
                        break;
                    default:
                        rbGodan.Checked = true;
                        break;
                }


                // inflections are based off of class structure
                foreach(Inflection newInfl in controlVerb.inflections)
                {
                    lbInflections.Items.Add(newInfl);

                    // each inflection will have its own group of tenses so load those
                    foreach(Tense tense in newInfl.Tenses)
                    {
                        lbTenses.Items.Add(tense);
                    }
                }

                    
            }
            else
            {
                ClearAll();
            }
        }

        private void tbEnableSave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbKanji.Text.Trim())
                && !string.IsNullOrEmpty(tbHiragana.Text.Trim())
                && !string.IsNullOrEmpty(tbRomaji.Text.Trim())
                && !string.IsNullOrEmpty(tbMeaning.Text.Trim())
                && !string.IsNullOrEmpty(tbKanjiCharacter.Text.Trim())){
                bSave.Enabled = true;
               
            }
            else
            {
                bSave.Enabled = false;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            tbKanji.Text = String.Empty;
            tbHiragana.Text = String.Empty;
            tbKanjiCharacter.Text = String.Empty;
            tbMeaning.Text = String.Empty;
            tbRomaji.Text = String.Empty;

            lbInflections.Items.Clear();
            lbTenses.Items.Clear();
            rbGodan.Checked = true;

            newVerb = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if(newVerb == true)
            {
                Verb newCreation;
                // ignore parent and create new data just based on this frame
                // only enabled if chars enough. Create new object dependant on verb type
                if (rbIchidan.Checked)
                {
                    newCreation = new IchidanVerb(tbKanji.Text.Trim(), tbHiragana.Text.Trim(), tbRomaji.Text.Trim(), tbMeaning.Text.Trim(), Guid.NewGuid(), tbKanjiCharacter.Text.Trim(), false);
                    dataAccessLayer.SaveVerb(newCreation);

                }
                else if(rbGodan.Checked)
                {
                    newCreation = new GodanVerb(tbKanji.Text.Trim(), tbHiragana.Text.Trim(), tbRomaji.Text.Trim(), tbMeaning.Text.Trim(), Guid.NewGuid(), tbKanjiCharacter.Text.Trim(), false);
                    dataAccessLayer.SaveVerb(newCreation);
                }
                ClearAll();
                
            }
           
            

        }

        private void lbDrawInflection(object sender, DrawItemEventArgs e) {

            e.DrawBackground();

            Brush standardBrush = Brushes.Black;

            object display = ((ListBox)sender).Items[e.Index];
            Inflection disp = (Inflection)display;

            if (!disp.IsValid())
            {
                standardBrush = Brushes.Red;
            }

            

            e.Graphics.DrawString(disp.Name,
                e.Font, standardBrush, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        private void lbDrawTense(object sender, DrawItemEventArgs e)
        {

            e.DrawBackground();

            Brush standardBrush = Brushes.Black;

            object display = ((ListBox)sender).Items[e.Index];
            Tense disp = (Tense)display;

            if (!disp.IsValid())
            {
                standardBrush = Brushes.Red;
            }



            e.Graphics.DrawString(disp.ToString(), e.Font, standardBrush, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerbDetail newDetailWindow = new VerbDetail(controlVerb);
            newDetailWindow.ShowDialog(this);
            
        }
    }
}
