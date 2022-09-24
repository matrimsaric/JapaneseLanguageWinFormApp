using JapaneseLanguageWinForm.DataLibaryAccess;
using LanguageConsult.DataAccess;
using LanguageConsult.Verbs;
using LanguageConsult.Verbs.InflectionControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLanguageWinForm.GUI
{
    public partial class InflectionEntry : Form
    {
        private Inflection targetInflection;
        private bool blockAutoGenerate = false;
        public InflectionEntry(Inflection target)
        {
            targetInflection = target;
            InitializeComponent();

            this.SetVisible();
            this.Display();
        }

        private void SetVisible()
        {
            if(JapaneseLanguageWinForm.Properties.Resources.ShowNotes.ToUpper() == "FALSE")
            {
                cbHideNotes.Checked = true;
            }
            else
            {
                cbHideNotes.Checked = false;
            }

            if (JapaneseLanguageWinForm.Properties.Resources.ShowRomaji.ToUpper() == "FALSE")
            {
                cbHideRomaji.Checked = true;
            }
            else
            {
                cbHideRomaji.Checked = false;
            }
        }

        private void Display()
        {
            tbName.Text = targetInflection.Name;
            int count = 0;

            // for each valid tense enable in order
            foreach(Tense tense in targetInflection.Tenses)
            {
                

                switch (count)
                {
                    case 0:
                        SetTenseText(tense, lTense1, tbTense1Kanji, tbTense1Hiragana, tbTense1Romaji, tbTense1Meaning, tbNotes1);
                        break;
                    case 1:
                        SetTenseText(tense, lTense2, tbTense2Kanji, tbTense2Hiragana, tbTense2Romaji, tbTense2Meaning, tbNotes2);
                        break;
                    case 2:
                        SetTenseText(tense, lTense3, tbTense3Kanji, tbTense3Hiragana, tbTense3Romaji, tbTense3Meaning, tbNotes3);
                        break;
                    case 3:
                        SetTenseText(tense, lTense4, tbTense4Kanji, tbTense4Hiragana, tbTense4Romaji, tbTense4Meaning, tbNotes4);
                        break;
                }

                count++;


            }

            if(count < 3)
            {
                HideInvalidTenses(lTense4, tbTense4Kanji, tbTense4Hiragana, tbTense4Romaji, tbTense4Meaning, tbNotes4);
            }
            if(count < 2)
            {
                HideInvalidTenses(lTense3, tbTense3Kanji, tbTense3Hiragana, tbTense3Romaji, tbTense3Meaning, tbNotes3);
            }
            if(count < 1)
            {
                HideInvalidTenses(lTense2, tbTense2Kanji, tbTense2Hiragana, tbTense2Romaji, tbTense2Meaning, tbNotes2);
            }
            
            
        }

        

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            // there are up to 4 tenses. get each in turn from the Inflection then save 
            foreach(Tense saveTense in targetInflection.Tenses)
            {
               
                switch (count)
                {
                    case 0:
                        saveTense.UpdateValues(tbTense1Kanji.Text.Trim(), tbTense1Hiragana.Text.Trim(), tbTense1Romaji.Text.Trim(),
                            tbTense1Meaning.Text.Trim(), tbNotes1.Text.Trim());
                        DataControlSingleton.GetDataAccess().SaveTense(saveTense);
                        break;
                    case 1:
                        saveTense.UpdateValues(tbTense2Kanji.Text.Trim(), tbTense2Hiragana.Text.Trim(), tbTense2Romaji.Text.Trim(),
                            tbTense2Meaning.Text.Trim(), tbNotes2.Text.Trim());
                        DataControlSingleton.GetDataAccess().SaveTense(saveTense);
                        break;
                    case 2:
                        saveTense.UpdateValues(tbTense3Kanji.Text.Trim(), tbTense3Hiragana.Text.Trim(), tbTense3Romaji.Text.Trim(),
                            tbTense3Meaning.Text.Trim(), tbNotes3.Text.Trim());
                        DataControlSingleton.GetDataAccess().SaveTense(saveTense);
                        break;
                    case 3:
                        saveTense.UpdateValues(tbTense4Kanji.Text.Trim(), tbTense4Hiragana.Text.Trim(), tbTense4Romaji.Text.Trim(),
                            tbTense4Meaning.Text.Trim(), tbNotes4.Text.Trim());
                        DataControlSingleton.GetDataAccess().SaveTense(saveTense);
                        break;
                }
                count++;
            }

            this.Close();


        }


        #region Object setters/getters
        private void SetTenseText(Tense target, Label label, TextBox kanji, TextBox hiragana, TextBox romaji, TextBox meaning, TextBox notes)
        {
            label.Text = target.tenseType.ToString();
            kanji.Text = target.Kanji;
            hiragana.Text = target.Hiragana;
            meaning.Text = target.Meaning;
            romaji.Text = target.Romaji;
            notes.Text = target.Notes;
        }

        private void HideInvalidTenses(Label label, TextBox kanji, TextBox hiragana, TextBox romaji, TextBox meaning, TextBox notes)
        {
            label.Visible = false;
            kanji.Visible = false;
            hiragana.Visible = false;
            romaji.Visible = false;
            meaning.Visible = false;
            notes.Visible = false;
        }


        #endregion Object setters/getters

        private void cbHideRomaji_CheckedChanged(object sender, EventArgs e)
        {
            HideShowRomajiSection(!cbHideRomaji.Checked);
        }

        private void HideShowRomajiSection(bool hide)
        {
            tbTense1Romaji.Visible = hide;
            tbTense2Romaji.Visible = hide;
            tbTense3Romaji.Visible = hide;
            tbTense4Romaji.Visible = hide;
            label8.Visible = hide;
        }

        private void HideShowNotesSection(bool hide)
        {
            tbNotes1.Visible = hide;
            tbNotes2.Visible = hide;
            tbNotes3.Visible = hide;
            tbNotes4.Visible = hide;
            label10.Visible = hide;
        }

        private void cbHideNotes_CheckedChanged(object sender, EventArgs e)
        {
            HideShowNotesSection(!cbHideNotes.Checked);
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

        private void tbTense1Kanji_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo japaneseCulture = new System.Globalization.CultureInfo("ja-JP");
       
            SetKeyboardLayout(System.Windows.Forms.InputLanguage.FromCulture(japaneseCulture));
        }

        private void tbTense1Meaning_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo englishCUlture = new System.Globalization.CultureInfo("en-GB");

            SetKeyboardLayout(System.Windows.Forms.InputLanguage.FromCulture(englishCUlture));
        }

        private void tbTense1Kanji_TextChanged(object sender, EventArgs e)
        {
            // copy this to all other boxes IF empty
            if (tbTense1Kanji.Text.Length > 0)
            {
                blockAutoGenerate = true;
                if (String.IsNullOrEmpty(tbTense2Kanji.Text.Trim())) tbTense2Kanji.Text = tbTense1Kanji.Text.Substring(0, tbTense1Kanji.Text.Length - 1);
                if (String.IsNullOrEmpty(tbTense3Kanji.Text.Trim())) tbTense3Kanji.Text = tbTense1Kanji.Text.Substring(0, tbTense1Kanji.Text.Length - 1);
                if (String.IsNullOrEmpty(tbTense4Kanji.Text.Trim())) tbTense4Kanji.Text = tbTense1Kanji.Text.Substring(0, tbTense1Kanji.Text.Length - 1);
                blockAutoGenerate = false;
            }

        }

        private void tbTense1Hiragana_TextChanged(object sender, EventArgs e)
        {
            // copy this to all other boxes IF empty
            if(tbTense1Hiragana.Text.Length > 0)
            {
                blockAutoGenerate = true;
                if (String.IsNullOrEmpty(tbTense2Hiragana.Text.Trim())) tbTense2Hiragana.Text = tbTense1Hiragana.Text.Substring(0, tbTense1Hiragana.Text.Length - 1);
                if (String.IsNullOrEmpty(tbTense3Hiragana.Text.Trim())) tbTense3Hiragana.Text = tbTense1Hiragana.Text.Substring(0, tbTense1Hiragana.Text.Length - 1);
                if (String.IsNullOrEmpty(tbTense4Hiragana.Text.Trim())) tbTense4Hiragana.Text = tbTense1Hiragana.Text.Substring(0, tbTense1Hiragana.Text.Length - 1);
                blockAutoGenerate = false;
            }
            
        }

        private void autoGenerateHiragana(object sender, EventArgs e)
        {
            if (blockAutoGenerate == true)
                return;

            if(cbAutoHirgana.Checked == false)
            {
                return;
            }
            

            TextBox sendBox = (TextBox)sender;
            string tag = sendBox.Tag.ToString();
            string currTex = String.Empty;

            string box1Text = tbTense1Kanji.Text.Trim();
            int initialBoxLength = box1Text.Length-1;

            if (string.IsNullOrEmpty(tbTense1Hiragana.Text.Trim())) return;

            switch (tag)
            {
                case "2":
                    // get split
                    currTex = tbTense2Kanji.Text.Trim();
                    if (string.IsNullOrEmpty(currTex)) return;
                    string diff = currTex.Substring(initialBoxLength);

                    

                    tbTense2Hiragana.Text = tbTense2Hiragana.Text + diff;
                    break;
                case "3":
                    currTex = tbTense3Kanji.Text.Trim();
                    if (string.IsNullOrEmpty(currTex)) return;
                    string diff3 = currTex.Substring(initialBoxLength);

                    tbTense3Hiragana.Text = tbTense3Hiragana.Text + diff3;
                    break;
                case "4":
                    currTex = tbTense4Kanji.Text.Trim();
                    if (string.IsNullOrEmpty(currTex)) return;
                    string diff4 = currTex.Substring(initialBoxLength);

                    tbTense4Hiragana.Text = tbTense4Hiragana.Text + diff4;
                    break;
            }
        }
    }
}
