using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OOP_Project_3D.Managers;

namespace OOP_Project_3D.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishLight;
        [SerializeField] GameObject _finishFireWorks;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if (player == null) return;

            if (collision.GetContact(0).normal.y == -1)
            {
                _finishLight.SetActive(true);
                _finishFireWorks.SetActive(true);
            }
            else
            {
                //Game Over
                GameManager.Instance.GameOver();
            }
        }
    }
}


