using UnityEngine;
using OOP_Project_3D.Abstracts.Utilities;

namespace OOP_Project_3D.Managers
{
    public class SoundManager : SingletonThisObject<SoundManager>
    {
        AudioSource[] _audioSource;

        private void Awake()
        {
            SingletonThisGameObject(this);

            _audioSource = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if (!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
        }

        public void StopSound(int index)
        {
            if (_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            }
        }

    }
}

