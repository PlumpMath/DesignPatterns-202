namespace StatePattern.WizardControl
{
    public abstract class WizardStep
    {
        public abstract void Next(Wizard c);

        public abstract void Previous(Wizard c);

    }
}
