using UnityEngine;


namespace Scripts.Components
{
    public class DestroyGold : MonoBehaviour
    {
        [SerializeField] private GameObject _objToDestroy;

        public void DestroyObject()
        {
            Destroy(_objToDestroy);
            Hero.totalScore += 10;
            Debug.Log("Money " + Hero.totalScore);
        }
    }
}