namespace OOP_Project_3D.Inputs
{
    public class DefaultInput
    {
        private DefaultAction _input;

        public bool IsForceUp { get; private set; }
        public float LeftRight { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();

            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
            _input.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>();

            _input.Enable();
        }
    }
}


