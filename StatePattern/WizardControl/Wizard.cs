namespace StatePattern.WizardControl
{
    public class Wizard
    {
        private WizardStep _currentState;

        public Wizard()
        {
            // Initialize the Wizard with first Step as the Selected Step
            this.SetCurrentStep(new FirstStep());
        }
        public void SetCurrentStep(WizardStep state)
        {
            this._currentState = state;
        }

        public void GoNext()
        {
            _currentState.Next(this);
        }

        public void GoPrevious()
        {
            _currentState.Previous(this);
        }
    }
}
