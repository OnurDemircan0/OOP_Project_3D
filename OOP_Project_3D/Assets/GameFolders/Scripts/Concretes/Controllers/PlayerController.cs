using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP_Project_3D.Inputs;
using OOP_Project_3D.Movements;
using OOP_Project_3D.Managers;

namespace OOP_Project_3D.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnSpeed = 30;
        [SerializeField] float _force = 900;

        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;
        Fuel _fuel;

        bool _canMove;
        bool _canForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        public bool CanMove => _canMove;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }

        private void Start()
        {
            _canMove = true;
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTriggered;
            GameManager.Instance.OnMissionSucceed += HandleOnEventTriggered;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTriggered;
            GameManager.Instance.OnMissionSucceed -= HandleOnEventTriggered;
        }

        private void Update()
        {
            if (!_canMove) return;

            if (_input.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.1f);
            }

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _rotator.FixedTick(_leftRight);
        }

        private void HandleOnEventTriggered()
        {
            _canMove = false;
            _canForceUp = false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);
        }

    }
}


