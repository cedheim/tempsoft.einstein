using UnityEngine;

namespace TempSoft.Einstein.Unity.Assets.Scripts.Behaviours
{
    public class TestBehaviour : MonoBehaviour
    {
        public int Counter;

        // Use this for initialization
        public void Start()
        {
            Counter = 0;
        }

        // Update is called once per frame
        public void Update()
        {
            ++Counter;
        }
    }
}

