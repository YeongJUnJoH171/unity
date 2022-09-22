using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private ScoreManager scoreManager = null;

    
    void Start()
    {
        GameObject smObject = GameObject.Find("ScoreManager");
        scoreManager = smObject.GetComponent<ScoreManager>();

       
  
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        scoreManager.OnTargetHit();
        Destroy(gameObject);
        
    }

    


}
