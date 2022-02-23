using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Components
{
    public class DamageComponent : MonoBehaviour
    {
        [SerializeField] private int _hpDelta;

        public void ApplyHealth(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthComponent>();

            if (healthComponent != null)
            {
                healthComponent.ApplyDamage(_hpDelta);
            }
        }
    }
}
