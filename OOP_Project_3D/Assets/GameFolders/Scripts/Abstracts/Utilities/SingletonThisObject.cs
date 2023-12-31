using UnityEngine;

namespace OOP_Project_3D.Abstracts.Utilities
{
    public abstract class SingletonThisObject<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected void SingletonThisGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}

