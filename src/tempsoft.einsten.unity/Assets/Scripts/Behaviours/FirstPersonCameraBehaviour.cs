using System;
using UnityEngine;

namespace TempSoft.Einstein.Unity.Assets.Scripts.Behaviours
{
    [RequireComponent(typeof(Camera))]
    public class FirstPersonCameraBehaviour : MonoBehaviour
    {
        private Camera _camera;

        public void Awake() 
        {
            
        }

        public void OnEnable()
        {
            
        }

        public void OnDisable()
        {
            
        }

        public void OnDestroy() 
        {
            
        }

        // Use this for initialization
        public void Start()
        {
            _camera = this.GetComponent<Camera>();
        }

        // Update is called once per frame
        public void Update()
        {

        }
    }
}


