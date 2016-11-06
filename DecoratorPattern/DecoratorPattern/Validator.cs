namespace DecoratorPattern
{
    public abstract class Validator
    {
        public abstract bool Validate(string value);
        public abstract void Draw(string value);
    }
}
