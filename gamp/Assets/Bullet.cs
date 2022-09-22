using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float timeMax = 3.0f;
    private float time = 0.0f;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (timeMax <= time)
        {
            Destroy(gameObject);
        }

    }
}
