using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_7___Aflevering___Models;

namespace Session_7___Aflevering___BL
{
    public class ValidateVaregruppe
    {

        public bool ValidateVaregruppeName(Varegruppe varegruppe)
        {
            if (varegruppe.Name != null)
            {
                if (varegruppe.Name.Length > 1 && varegruppe.Name.Length < 51)
                {
                    if (varegruppe.Name.Length > 1 && varegruppe.Name.Length < 51)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ValidateVaregruppeDescription(Varegruppe varegruppe)
        {
            if ((varegruppe.Description == null) || (varegruppe.Description.Length <= 200))
            {
                return true;
            }
            return false;
        }
    }
}

