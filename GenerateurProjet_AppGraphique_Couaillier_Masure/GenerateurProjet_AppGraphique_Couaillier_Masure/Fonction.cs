﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateurProjet_AppGraphique_Couaillier_Masure
{
    class Fonction
    {        //VAR
        private String nom;
        private String type;
        private TypeVisibility visibility;
        private Boolean Static;

        public Fonction (String nom, String type, TypeVisibility visibility, Boolean Static)
        {
            this.nom = nom;
            this.type = type;
            this.visibility = visibility;
        }

        //Mutateur

        //Accessseur

        //Fonction
        public void Ecrire()
        {
            /*
             * ecrire :
             * using System;\n\nnamespace 
             */
            if (this.type != "Void")
            {
                /* 
                 * ecrire ("return null //doit etre un"+type)
                 */
            }
            //ecrire "}}"
        }
    }
}

    }
}
