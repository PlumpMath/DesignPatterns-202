using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class PointDecorator: Validator
    {
        private readonly Validator _validator;

        protected PointDecorator(Validator validator)
        {
            this._validator = validator;
        }


        public override bool Validate(string value)
        {
           return _validator.Validate(value);
        }

        public override void Draw(string value)
        {
           _validator.Draw(value);
        }
    }
}
