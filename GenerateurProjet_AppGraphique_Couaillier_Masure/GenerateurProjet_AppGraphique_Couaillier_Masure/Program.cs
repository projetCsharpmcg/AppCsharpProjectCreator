using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GenerateurProjet_AppGraphique_Couaillier_Masure
{
    static class Program
    {
        //Variable global
        public static string folder;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        
        
        /*public static ArrayList ListClass;
        public static ArrayList ListVar;
        public static ArrayList ListFonct;*/


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_NouveauProjet NouveauProjet = new Form_NouveauProjet();
            Application.Run(NouveauProjet);
            Form_Menu MenuDuProjet = new Form_Menu();
            Application.Run(MenuDuProjet);
        }
    }
}
