using UnityEngine;


namespace Scripts.Components
{
    public class DestroySillver : MonoBehaviour
    {
        [SerializeField] private GameObject _objToDestroy;

        public void DestroyObject()
        {
            Destroy(_objToDestroy);
            Hero.totalScore += 1;
            Debug.Log("Money " + Hero.totalScore);
        }
    }
}