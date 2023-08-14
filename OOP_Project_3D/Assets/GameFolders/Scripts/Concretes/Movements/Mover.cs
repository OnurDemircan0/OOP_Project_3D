using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP_Project_3D.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody;

        public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 900);
        }
    }
}


