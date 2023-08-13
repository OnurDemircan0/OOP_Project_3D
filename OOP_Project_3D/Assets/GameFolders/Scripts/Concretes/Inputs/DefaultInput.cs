using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP_Project_3D.Inputs
{
    public class DefaultInput
    {
        private DefaultAction _input;

        public bool isForceUp { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();

            _input.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();

            _input.Enable();
        }
    }
}


