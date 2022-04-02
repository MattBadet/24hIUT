using System;
using System.Collections.Generic;
using System.Text;

namespace projectRexma
{
    public class Carte
    {
        // Type de la carte
        private TypeCarte typeCarte;

        // Renvoie le nombre de points de la carte
        public double Point
        {
            get {
                double Result = 0;
                switch (this.typeCarte)
                {
                    case TypeCarte.ALIGOTE:
                        Result = 0.8;
                        break;
                    case TypeCarte.CHARDONNAY:
                        Result = 1.0;
                        break;
                    case TypeCarte.GAMAY:
                        Result = 0.9;
                        break;
                    case TypeCarte.PINOY:
                        Result = 1.2;
                        break;
                    
                }
                return Result;
            }
        }







    }
}
