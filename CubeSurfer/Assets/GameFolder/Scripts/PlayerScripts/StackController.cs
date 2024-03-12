using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfer.PlayerScripts
{
    public class StackController : MonoBehaviour
    {
        public List<GameObject> _cubeList = new List<GameObject>();
        private GameObject _lastCube;

        private void Start()
        {
            UpdateLastCube();
        }

        public void StackCube(GameObject gameObject)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
            gameObject.transform.position = new Vector3(_lastCube.transform.position.x, _lastCube.transform.position.y - 2, _lastCube.transform.position.z);
            gameObject.transform.SetParent(transform);
            _cubeList.Add(gameObject);
            UpdateLastCube();
        }

        public void RemoveCube(GameObject gameObject)
        {
            Debug.Log("a");
            gameObject.transform.parent = null;
            _cubeList.Remove(gameObject);
            UpdateLastCube();
        }

        void UpdateLastCube()
        {
            _lastCube = _cubeList[_cubeList.Count - 1];
        }
    }
}

