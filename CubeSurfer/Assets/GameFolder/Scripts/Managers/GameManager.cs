using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfer.Utilities;

namespace CubeSurfer.Managers
{
    public class GameManager : SingletonMonobehaviorObject<GameManager>
    {
        public event System.Action OnGameStop;

        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0;
            if(OnGameStop != null)
            {
                OnGameStop();
            }
            OnGameStop?.Invoke();
        }
    }
}

