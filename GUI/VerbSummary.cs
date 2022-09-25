using JapaneseLanguageWinForm.DataLibaryAccess;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLanguageWinForm.GUI
{
    
    public partial class VerbSummary : Form
    {
        private Verb controlVerb;
        private bool newVerb = true;
        private Assembly imageAssembly = null;

        public VerbSummary()
        {
            InitializeComponent();

            lbInflections.DrawMode = DrawMode.OwnerDrawFixed;
            lbInflections.DrawItem += new DrawItemEventHandler(lbDrawInflection);
            lbTenses.DrawMode = DrawMode.OwnerDrawFixed;
            lbTenses.DrawItem += new DrawItemEventHandler(lbDrawTense);

            LoadImageAssembly(JapaneseLanguageWinForm.Properties.Resources.ImageLibraryDllName);
        }

        private void LoadImageAssembly(string assemblyName)
        {
            llKanjiCharacter.Enabled = false;
            llKanjiCharacter.ForeColor = Color.Black;
            // TODO live path in test env is C:\ProgramData\JapaneseLanguageWinForm\JapaneseLanguageWinForm\1.0.0
            // make this a resource as well
            string livePath = $"{Application.CommonAppDataPath}{Path.DirectorySeparatorChar}{assemblyName}";

            try
            {
                // search for our dll
                var assembly = Assembly.LoadFile(livePath);

                if(assembly != null)
                {
                    imageAssembly = assembly;
                    llKanjiCharacter.Enabled = true;
                    llKanjiCharacter.ForeColor = Color.Blue;
                }
            }
            catch(System.BadImageFormatException ex)
            {
                // not an assembly..
            }
            


        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLookup_Click(object sender, EventArgs e)
        {
            VerbSearchDialogue searcher = new VerbSearchDialogue();
 
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
            Task<Verb> loadedVerb = DataControlSingleton.GetDataAccess().LoadSpecificVerb(targetId);
            lbInflections.Items.Clear();
            lbTenses.Items.Clear();

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

                    
                }

                    
            }
            else
            {
                ClearAll();
            }
        }

        private bool EnableSave()
        {
            if(!string.IsNullOrEmpty(tbKanji.Text.Trim())
                && !string.IsNullOrEmpty(tbHiragana.Text.Trim())
                && !string.IsNullOrEmpty(tbRomaji.Text.Trim())
                && !string.IsNullOrEmpty(tbMeaning.Text.Trim())
                && !string.IsNullOrEmpty(tbKanjiCharacter.Text.Trim())){
                return true;

            }
            return false;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            if (EnableSave() == false)
            {
                return;
            }
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
            if(EnableSave() == false)
            {
                return;
            }
            if(newVerb == true)
            {
                Verb newCreation;
                // ignore parent and create new data just based on this frame
                // only enabled if chars enough. Create new object dependant on verb type
                if (rbIchidan.Checked)
                {
                    newCreation = new IchidanVerb(tbKanji.Text.Trim(), tbHiragana.Text.Trim(), tbRomaji.Text.Trim(), tbMeaning.Text.Trim(), Guid.NewGuid(), tbKanjiCharacter.Text.Trim(), false);
                    DataControlSingleton.GetDataAccess().SaveVerb(newCreation);

                }
                else if(rbGodan.Checked)
                {
                    newCreation = new GodanVerb(tbKanji.Text.Trim(), tbHiragana.Text.Trim(), tbRomaji.Text.Trim(), tbMeaning.Text.Trim(), Guid.NewGuid(), tbKanjiCharacter.Text.Trim(), false);
                    DataControlSingleton.GetDataAccess().SaveVerb(newCreation);
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

        private void lbInflections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Inflection choice = (Inflection)lbInflections.SelectedItem;
            // when item double clicked open InflectionEntry detail window
            InflectionEntry entryWin = new InflectionEntry(choice);
            entryWin.Show();
        }

        private void lbInflections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbInflections.SelectedIndex != -1)
            {
                lbTenses.Items.Clear();
                Inflection chosen = (Inflection)lbInflections.SelectedItem;
                // each inflection will have its own group of tenses so load those
                foreach (Tense tense in chosen.Tenses)
                {
                    lbTenses.Items.Add(tense);
                }
            }
        }

        private void llKanjiCharacter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbRomaji.Text))
            {
                // open kanji frame
                KanjiDetails kanj = new KanjiDetails(tbRomaji.Text.Trim(), imageAssembly, JapaneseLanguageWinForm.Properties.Resources.ImageLibraryDllShortName);
                kanj.ShowDialog(this);
            }
            
        }

        private void SetKeyboardLayout(InputLanguage layout)
        {
            string lay = layout.Culture.EnglishName.ToString().ToUpperInvariant();
            foreach (InputLanguage Lng in InputLanguage.InstalledInputLanguages)
            {

                if (Lng.Culture.EnglishName.ToUpperInvariant().StartsWith(lay))
                {
                    InputLanguage.CurrentInputLanguage = Lng;
                    System.Threading.Thread.CurrentThread.CurrentCulture = layout.Culture;
                }

            }

        }

        private void tbJapaneseBoxEntered(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo japaneseCulture = new System.Globalization.CultureInfo("ja-JP");

            SetKeyboardLayout(System.Windows.Forms.InputLanguage.FromCulture(japaneseCulture));
        }

        private void tbJEnglishBoxEntered(object sender, EventArgs e)
        {
            // TODO the Japanese is a given, this should be a setting so the language can match the users preference
            System.Globalization.CultureInfo otherCulture = new System.Globalization.CultureInfo("en-GB");

            SetKeyboardLayout(System.Windows.Forms.InputLanguage.FromCulture(otherCulture));
        }
    }
}
