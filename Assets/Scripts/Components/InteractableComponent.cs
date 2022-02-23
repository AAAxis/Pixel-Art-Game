using UnityEngine;
using UnityEngine.Events;

namespace Scripts.Components
{
    public class InteractableComponent : MonoBehaviour
    {
        [SerializeField] private UnityEvent _actions;

        public void Interact()
        {
            _actions?.Invoke();
        }
    }
}
