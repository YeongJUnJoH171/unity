using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    

    public float sensitivity = 700.0f; 

    // axis Y = left right
    // asix X = up down
    float rotationX = 0;
    float rotationY = 0; 


    //fixing cursor
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        
        float mouseMoveValueX = Input.GetAxis("Mouse X");
        float mouseMoveValueY = Input.GetAxis("Mouse Y");

        rotationX += mouseMoveValueX * sensitivity * Time.deltaTime; 
        rotationY += mouseMoveValueY * sensitivity * Time.deltaTime; 
        // 실제 게임에서 마우스를 움직이며 해기

        rotationY = Mathf.Clamp(rotationY, -50.0f, 60.0f); 

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);



    }
}
