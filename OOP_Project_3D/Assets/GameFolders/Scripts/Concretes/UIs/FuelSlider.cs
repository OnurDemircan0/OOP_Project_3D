using UnityEngine;
using UnityEngine.UI;
using OOP_Project_3D.Movements;

namespace OOP_Project_3D.UIs
{
    public class FuelSlider : MonoBehaviour
    {
        Slider _slider;
        Fuel _fuel;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _fuel = FindObjectOfType<Fuel>();
        }

        private void Update()
        {
            _slider.value = _fuel.CurrrentFuel;
        }
    }
}

