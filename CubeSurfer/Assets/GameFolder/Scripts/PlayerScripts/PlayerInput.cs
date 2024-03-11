using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfer.PlayerScripts
{
    public class PlayerInput : MonoBehaviour
    {
        private float _horizontal;
        public float Horizontal { get { return _horizontal; } }

        private void Update()
        {
            HandlePlayerHorizontalInput();
        }

        private void HandlePlayerHorizontalInput()
        {
            if (Input.GetMouseButton(0))
            {
                _horizontal = Input.GetAxis("Mouse X");
            }
            else
            {
                _horizontal = 0;
            }
        }
    }
}

