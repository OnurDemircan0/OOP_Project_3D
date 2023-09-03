using UnityEngine;
using OOP_Project_3D.Managers;

namespace OOP_Project_3D.UIs
{
    public class WinPanel : MonoBehaviour
    {
        public void NextLevelClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void MainMenuClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}


