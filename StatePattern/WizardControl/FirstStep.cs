using System;

namespace StatePattern.WizardControl
{
    public class FirstStep : WizardStep
    {
        public FirstStep()
        {
            Console.WriteLine("---- Currently in First Step--------");
        }
        public override void Next(Wizard c)
        {
            Console.WriteLine("Swithcing from First Step to Second Step");
            c.SetCurrentStep(new SecondState());
        }

        public override void Previous(Wizard c)
        {
            Console.WriteLine("Error: You can not go to previous from First Step");
        }
    }
}
