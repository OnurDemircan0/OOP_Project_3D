using UnityEngine;
using OOP_Project_3D.Managers;

namespace OOP_Project_3D.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel = 100;
        [SerializeField] float _currentFuel;
        [SerializeField] GameObject _particle;

        public bool IsEmpty => _currentFuel < 1f;
        public float CurrrentFuel => _currentFuel / _maxFuel;

        private void Awake()
        {
            _currentFuel = _maxFuel;
        }

        public void FuelIncrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);

            if (_particle.activeSelf)
            {
                _particle.SetActive(false);
            }

            SoundManager.Instance.StopSound(0);
        }

        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel, 0f);

            if (!_particle.activeSelf)
            {
                _particle.SetActive(true);
            }

            SoundManager.Instance.PlaySound(0);
        }
    }
}


