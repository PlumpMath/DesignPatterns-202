using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeForm.Formfields
{
    public class FullName : FormElement
    {
        public FullName(string name, string value) : base(name, value)
        {
        }

        public override void Add(FormElement element)
        {
            throw new InvalidOperationException("Can not Add elements to basic form Element");
        }

        public override bool IsValid()
        {
            return value != null && value.Length > 5;
        }

        public override string ErrorMessage
        {
            get { return IsValid() ? string.Empty : string.Format("{0} should be at least 6 charecters long",base.Name); }
        }
    }
}
