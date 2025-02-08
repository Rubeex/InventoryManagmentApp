using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentApp.Utils
{
    public static class ValidatorHelper
    {
        public static bool ValidateEntity(object entity , Dictionary<string, ErrorProvider> errorProviders, 
            Control parentControl) 
        { 
            var context = new ValidationContext(entity);
            var results = new List<ValidationResult>();
            foreach (var errorProvider in errorProviders.Values)
            {
                errorProvider.Clear();
            }

            bool isValid = Validator.TryValidateObject(entity,context,results,true);

            if (!isValid)
            {
                foreach (var result in results)
                {
                    foreach(var memberName in result.MemberNames)
                    {
                        var control = parentControl.Controls.OfType<Control>()
                            .FirstOrDefault(x => x.Tag != null && x.Tag.ToString() == memberName); 

                        if (control != null)
                        {
                            if (errorProviders.ContainsKey(memberName))
                            {
                                errorProviders[memberName].SetError(control, result.ErrorMessage);
                            }
                        }
                    }

                }

            }
            return isValid;
        }
    }
}
