using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeForm
{
    public class CompositeFormElement: FormElement
    {
        private readonly List<FormElement> _elements;
        public CompositeFormElement(string name) : base(name,string.Empty)
        {
            _elements = new List<FormElement>();

        }

        public override void Add(FormElement element)
        {
            _elements.Add(element);
        }

        public override bool IsValid()
        {
            return _elements.All(element => element.IsValid());
        }

        public override string ErrorMessage
        {
            get
            {
                var erroMessage = new StringBuilder();
                foreach (var element in _elements.Where(element => !element.IsValid()))
                {
                    erroMessage.Append(element.ErrorMessage);
                    erroMessage.Append(Environment.NewLine);
                }
                return erroMessage.ToString();
            }
        }
    }
}
