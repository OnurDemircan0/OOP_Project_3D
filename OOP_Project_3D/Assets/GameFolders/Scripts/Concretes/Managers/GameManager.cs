using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OOP_Project_3D.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucceed;

        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            Application.targetFrameRate = 60;
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

        public void MissionSucceed()
        {
            OnMissionSucceed?.Invoke();
        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }

        public void Exit()
        {
            Application.Quit();
        }

    }
}


