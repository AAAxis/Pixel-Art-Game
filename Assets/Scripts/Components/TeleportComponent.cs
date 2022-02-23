using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Scripts.Components
{
    public class TeleportComponent : MonoBehaviour
    {
        [SerializeField] private Transform _destTransform;
        
        public void Teleport(GameObject target)
        {
            target.transform.position = _destTransform.position;
        }

    }
}
