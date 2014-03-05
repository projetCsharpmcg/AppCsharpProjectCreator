using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateurProjet_AppGraphique_Couaillier_Masure
{
    public partial class Form_NouveauProjet : Form
    {
        public Form_NouveauProjet()
        {
            InitializeComponent();
        }

        private void btn_resgister_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Program.folder =  folderBrowserDialog1.SelectedPath.ToString();
        }

        private void btn_Suivant_Click(object sender, EventArgs e)
        {
            string folderName = tbx_NomProjet.Text.ToString();
            string pathstring = System.IO.Path.Combine(Program.folder,folderName);
            System.IO.Directory.CreateDirectory(pathstring);
            //Form_Menu Menu = new Form_Menu();
            this.Close();
        }

        

        
    }
}
