using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateurProjet_AppGraphique_Couaillier_Masure
{
    class Variable
    {
        private String nom;
        private String type;
        private typeVisibilitee visibilitee;
        private bool accesseur;
        private bool mutateur;

        public Variable(String nom, String type, typeVisibilitee visibility, bool accesseur, bool mutateur)
        {
            this.nom = nom;
            this.type = type;
            this.visibilitee = visibilitee;
            this.accesseur = accesseur;
            this.mutateur = mutateur;
        }
        public void Ecrire()
        {
            EcrireAccesseur();
            EcrireMutateur();
        }
        private void EcrireAccesseur()
        {
            if (this.accesseur == true)
            {
                String Nom = nom[0].ToString().ToUpper() + nom.Substring(1);
                /*
                 * chercher le commentaire "// Accesseur"
                 * Ecrire : public+type+Nom+”()\n{\n{ get { return “+this.y+”;}\n}”
                 */

            }
        }
        private void EcrireMutateur()
        {
            if (this.mutateur == true)
            {

            }
        }
    }
}
