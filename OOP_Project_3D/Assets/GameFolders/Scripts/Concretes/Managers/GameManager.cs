using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP_Project_3D.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;

        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            SingletonThisGameObject();
        }

        private void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
        }

    }
}

