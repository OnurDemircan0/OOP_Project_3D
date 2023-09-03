using UnityEngine;
using OOP_Project_3D.Abstracts.Controllers;

namespace OOP_Project_3D.Controllers
{
    public class MovingWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed = 1;

        Vector3 _startPosition;
        float _factor;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            _factor = (Mathf.Sin(Time.time / (1 / _speed)) + 1f) / 2f;
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
        }
    }

}

