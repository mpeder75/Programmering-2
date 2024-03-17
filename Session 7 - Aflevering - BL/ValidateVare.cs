using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_7___Aflevering___Models;

namespace Session_7___Aflevering___BL
{
    public class ValidateVare
    {
        // name & description
        public bool ValidateVareName(Vare vare)
        {
            if (vare.Name != null && vare.Description != null)
            {
                if ((vare.Name.Length > 1 && vare.Name.Length < 51) && (vare.Description.Length <= 200))
                {
                    if (!string.IsNullOrEmpty(vare.Name) && (!string.IsNullOrEmpty(vare.Description)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        // stockammount
        //bool ValidateVareStockAmount(Vare vare) => vare.StockAmount != null;

        public bool ValidateVareStockAmount(Vare vare)
        {
            if((vare.StockAmount == null) || (vare.StockAmount >=0 && vare.StockAmount <= 1000))
            {
                return true;
            }             
                return false;            
        }

        public bool ValidateVarePrice(Vare vare)
        {
            if(vare.Price >= 1.0 && vare.Price <= int.MaxValue)
            {
                return true;
            }
            return false;
        }
    }
}

