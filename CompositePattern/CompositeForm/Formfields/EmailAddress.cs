using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompositePattern.CompositeForm.Formfields
{
    public class EmailAddress: FormElement
    {
        public EmailAddress(string name,string value) : base(name, value)
        {
        }

        public override void Add(FormElement element)
        {
            throw new InvalidOperationException("Can not Add elements to basic form Element");
        }

        public override bool IsValid()
        {
            if (value == null)
                return false;
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var match = regex.Match(value);
            return match.Success;
        }

        public override string ErrorMessage
        {
            get { return IsValid()? string.Empty: string.Format("Invalid {0}",base.Name); }

        }
    }
}
