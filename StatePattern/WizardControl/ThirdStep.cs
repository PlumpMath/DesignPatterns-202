using System;

namespace StatePattern.WizardControl
{
    public class ThirdState : WizardStep
    {
        public ThirdState()
        {
            Console.WriteLine("---- Currently in Third step--------");
        }
        public override void Next(Wizard c)
        {
            Console.WriteLine("Error: You can not go to next step from Third step.It is the last step");
        }

        public override void Previous(Wizard c)
        {
            Console.WriteLine("Switching from Third step to Second step");
            c.SetCurrentStep(new SecondState());

        }
    }
}