using UnityEngine;

namespace OOP_Project_3D.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if(player != null)
            {
                Destroy(gameObject);
            }
        }
    }
}


