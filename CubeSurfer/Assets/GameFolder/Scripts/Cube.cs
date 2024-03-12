using UnityEngine;
using CubeSurfer.PlayerScripts;
public class Cube : MonoBehaviour
{
    [SerializeField] private StackController _stackController;
    private RaycastHit _hit;
    private bool _isStack = false;
    private Vector3 _direction = Vector3.back;
    [SerializeField] LayerMask _cubeLayer;

    private void Start()
    {
        _stackController = GameObject.FindObjectOfType<StackController>();
    }

    private void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    { 
        if (Physics.BoxCast(transform.position, transform.localScale * 0.02f, _direction, out _hit, Quaternion.identity, 1f, _cubeLayer))
        {
            if (!_isStack)
            {
                _isStack = true;
                _stackController.StackCube(this.gameObject);
                SetDirection();
            }

            if (_hit.transform.CompareTag("ObstacleCube"))
            {
                _stackController.RemoveCube(this.gameObject);
            }
        }
    }

    private void SetDirection()
    {
        _direction = Vector3.forward;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, transform.localScale * 0.02f);
    }
}
