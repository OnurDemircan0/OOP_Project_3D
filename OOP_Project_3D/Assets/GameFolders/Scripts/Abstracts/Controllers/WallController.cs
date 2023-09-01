using UnityEngine;
using OOP_Project_3D.Managers;
using OOP_Project_3D.Controllers;

namespace OOP_Project_3D.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if(player != null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

