using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeForm
{
    public abstract class FormElement
    {
        protected string Name;
        protected string value;

        protected FormElement(string name,string value)
        {
            this.Name = name;
            this.value = value;
        }

        public abstract void Add(FormElement element);

        public abstract bool IsValid();

        public abstract string ErrorMessage { get; }
    }
}
