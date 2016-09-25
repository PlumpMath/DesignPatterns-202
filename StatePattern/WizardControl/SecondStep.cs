using System;

namespace StatePattern.WizardControl
{
    public class SecondState : WizardStep
    {
        public SecondState()
        {
            Console.WriteLine("---- Currently in Second Step--------");
        }
        public override void Next(Wizard c)
        {
            Console.WriteLine("Switching from Second step to third step");
            c.SetCurrentStep(new ThirdState());

        }

        public override void Previous(Wizard c)
        {
            Console.WriteLine("Switching  from Second to First step");
            c.SetCurrentStep(new FirstStep());
        }
    }
}