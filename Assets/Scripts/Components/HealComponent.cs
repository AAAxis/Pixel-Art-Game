using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Components
{
    public class HealComponent : MonoBehaviour
    {
        [SerializeField] private int _hpDelta;
        [SerializeField] private GameObject _objToDestroy;

        public void ApplyHealth(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthComponent>();

            if (healthComponent != null)
            {
                healthComponent.ApplyHeal(_hpDelta);
            }
        }
        public void DestroyObject()
        {
            Destroy(_objToDestroy);
            Debug.Log("Heal +5");
        }
    }
}
