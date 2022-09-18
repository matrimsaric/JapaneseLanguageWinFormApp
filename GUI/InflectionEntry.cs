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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLanguageWinForm.GUI
{
    public partial class InflectionEntry : Form
    {
        private Inflection targetInflection;
        public InflectionEntry(Inflection target)
        {
            targetInflection = target;
            InitializeComponent();

            this.Display();
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
    }
}
