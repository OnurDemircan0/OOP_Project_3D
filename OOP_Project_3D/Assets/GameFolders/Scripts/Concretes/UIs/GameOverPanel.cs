using UnityEngine;
using OOP_Project_3D.Managers;

namespace OOP_Project_3D.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void TryAgainClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void MainMenuClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}


