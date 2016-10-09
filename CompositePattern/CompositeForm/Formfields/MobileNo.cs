using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompositePattern.CompositeForm.Formfields
{
    public class MobileNo : FormElement
    {
        public MobileNo(string value) : base("MobileNo", value)
        {
        }

        public override void Add(FormElement element)
        {
            throw new InvalidOperationException("Can not Add elements to basic form Element");
        }

        public override bool IsValid()
        {
            var regex = new Regex(@"^\d{11}$");
            return value != null && regex.IsMatch(value);
        }

        public override string ErrorMessage
        {
            get { return IsValid() ? string.Empty : "Mobile Number must be 11 digit"; }
        }
    }
}
