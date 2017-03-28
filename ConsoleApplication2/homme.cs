using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class homme
    {
        public homme(int PID, String PNom, String PPrenom, DateTime Pddn)
        {
            ID = PID;
            Nom = PNom;
            DDN = Pddn;
        }

        private int ID;
        public String Nom;
        public String Prenom;
        public DateTime DDN;


        public Boolean EstMajeur()
        {
            if (DateTime.Today.Year - DDN.Year >= 18)
            {
                return true;
            }
            else return false;
        }

    }
}