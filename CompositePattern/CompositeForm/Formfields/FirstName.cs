using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeForm.Formfields
{
    public class FirstName : FormElement
    {
        public FirstName(string value) : base("FirstName",value)
        {

        }

        public override void Add(FormElement element)
        {
            throw new InvalidOperationException("Can not Add elements to basic form Element");
        }

        public override bool IsValid()
        {
            return value!=null && value.Length > 3;
        }

        public override string ErrorMessage
        {
            get
            {
                return IsValid() ? string.Empty: "First Name should be at least 4 charecters long";
            }
        }
    }
}
