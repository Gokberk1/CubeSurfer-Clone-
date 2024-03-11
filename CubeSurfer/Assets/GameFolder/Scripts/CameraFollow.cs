using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Vector3 _offset;
    private Vector3 _newPos;
    [SerializeField] private float _lerpValue;

    private void Start()
    {
        _offset = transform.position - _target.position;
    }

    private void LateUpdate()
    {
        SmoothFollow();
    }

    private void SmoothFollow()
    {
        _newPos = Vector3.Lerp(transform.position, new Vector3(0f, _target.position.y, _target.position.z) + _offset, _lerpValue * Time.deltaTime);
        transform.position = _newPos;
    }
}
