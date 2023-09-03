using UnityEngine;
using OOP_Project_3D.Managers;

namespace OOP_Project_3D.UIs
{
    public class WinObject : MonoBehaviour
    {
        [SerializeField] GameObject _winPanel;

        private void Awake()
        {
            if (_winPanel.activeSelf)
            {
                _winPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucceed += HandleOnMissionSucceed;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucceed -= HandleOnMissionSucceed;
        }

        private void HandleOnMissionSucceed()
        {
            if (!_winPanel.activeSelf)
            {
                _winPanel.SetActive(true);
            }
        }
    }

}

