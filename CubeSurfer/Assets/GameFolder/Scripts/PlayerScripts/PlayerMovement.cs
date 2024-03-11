using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfer.PlayerScripts
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] PlayerInput _playerInput;
        [SerializeField] float _forwardSpeed;
        [SerializeField] float _horizontalSpeed;
        [SerializeField] private float _horizontalLimit;
        private float newPositionX;

        private void FixedUpdate()
        {
            ForwardMovement();
            HorizontalMovement();
        }

        private void ForwardMovement()
        {
            transform.Translate(Vector3.forward * _forwardSpeed * Time.fixedDeltaTime);
        }

        private void HorizontalMovement()
        {
            newPositionX = transform.position.x + _playerInput.Horizontal * _horizontalSpeed * Time.fixedDeltaTime;
            newPositionX = Mathf.Clamp(newPositionX, -_horizontalLimit, _horizontalLimit);
            transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
        }
    }
}

