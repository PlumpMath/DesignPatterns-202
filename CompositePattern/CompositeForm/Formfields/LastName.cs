using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeForm.Formfields
{
    public class LastName : FormElement
    {
        public LastName(string value) : base("LastName", value)
        {
        }

        public override void Add(FormElement element)
        {
            throw new InvalidOperationException("Can not Add elements to basic form Element");
        }

        public override bool IsValid()
        {
            return value != null && value.Length > 2;
        }

        public override string ErrorMessage
        {
            get
            {
                return !IsValid() ? "LastName should be at least 3 charecters long" : string.Empty;
            }
        }
    }
}
