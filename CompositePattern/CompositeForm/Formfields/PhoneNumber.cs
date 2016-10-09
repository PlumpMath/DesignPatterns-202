using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompositePattern.CompositeForm.Formfields
{
    public class PhoneNumber : FormElement
    {
        public PhoneNumber(string name,string value) : base(name, value)
        {
        }

        public override void Add(FormElement element)
        {
            throw new InvalidOperationException("Can not Add elements to basic form Element");
        }

        public override bool IsValid()
        {
            var regex = new Regex(@"^\d{8}$");
            return value != null && regex.IsMatch(value);
        }

        public override string ErrorMessage { get { return IsValid() ? string.Empty : string.Format("{0} must be 8 digit",base.Name); } }
    }
}
