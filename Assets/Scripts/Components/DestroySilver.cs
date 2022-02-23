using UnityEngine;


public class DestroySilver : MonoBehaviour
    {
        [SerializeField] private GameObject _objToDestroy;
        private int score = 0;
        

        
        public void DestroyObject()
        {
            Destroy(_objToDestroy);
            Hero.totalScore += 1;
            Debug.Log(Hero.totalScore);
           
        }
        
        

        
    }