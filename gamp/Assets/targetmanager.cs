using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetmanager : MonoBehaviour
{
    

    //public Transform targetPosition;
    public GameObject prefab;
    GameObject obj;
    public float power = 3.0f;
    public float delta = 10.0f;

    float timer;
    int waitingTime;

    public Vector3 pos;
    

    void Start()
    {
       
        pos = transform.position;
        obj = Instantiate(prefab, transform.position, transform.rotation);
        timer = 0.0f;
        waitingTime = 2;

    }
    
    private void Update()
    {
       
        if (obj == null)
        {
            timer += Time.deltaTime;
            if(timer > waitingTime)
            {
                obj = Instantiate(prefab, transform.position, transform.rotation);
                timer = 0.0f;
            }
            
        }


        Vector3 v = pos;
        v.x += delta * Mathf.Sin((Time.time * power) / 4);
        obj.transform.position = v;
    }

    
    
    




}
