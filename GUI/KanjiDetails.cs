//using KanjiLineMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JapaneseLanguageWinForm.GUI
{
    public partial class KanjiDetails : Form
    {
        public Assembly ImageAssembly { get; private set; }
        private string displayedKanjiName = String.Empty;
        private string imageLibraryName = String.Empty;
        public KanjiDetails(string kanjiName, Assembly imageAssembly, string libraryName)
        {
            InitializeComponent();

            ImageAssembly = imageAssembly;
            displayedKanjiName = kanjiName + JapaneseLanguageWinForm.Properties.Resources.ImageLibraryImageType;
            imageLibraryName = libraryName;



            this.LoadImage();
        }

        private void LoadImage()
        {

            // before going full reflection make sure the call works by a direct call
            //ImageAccess imgAc = new ImageAccess();
            //Image res = imgAc.GetPNGImage(displayedKanjiName);
            //pbKanjiLines.Image = res;
            //return;

            string targetClassName = $"{imageLibraryName}.{JapaneseLanguageWinForm.Properties.Resources.ImageLibraryClassName}";
            Type accessPng = ImageAssembly.GetType(targetClassName);

            if (accessPng != null)
            {
                object imgAccessClass = Activator.CreateInstance(accessPng);

                string requiredMethodName = JapaneseLanguageWinForm.Properties.Resources.ImageLibraryMethodName;
                MethodInfo method = imgAccessClass.GetType().GetMethod(requiredMethodName);

                if (method != null)
                {
                    string[] args = new string[1];
                    args[0] = displayedKanjiName;

                    object imgObj = null;
                    object res = method.Invoke(imgAccessClass, args);
                    Image img = (Image)res;
                    pbKanjiLines.Image = img;
                }
            }

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
