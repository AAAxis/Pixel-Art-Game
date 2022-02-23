using UnityEngine;


public class DestroyGold : MonoBehaviour
    {
        [SerializeField] private GameObject _objToDestroy;
        private int score = 0;
        

        
        public void DestroyObject()
        {
            Destroy(_objToDestroy);
            Hero.totalScore += 10;
            Debug.Log(Hero.totalScore);
           
        }
        
        

        
    }