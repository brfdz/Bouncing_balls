using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    
    
    // Update is called once per frame
    void Update()
    {
        float currentX = transform.position.x;
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f);
        float moveAmount = speed * Time.deltaTime * horizontalInput;
        if ((currentX + moveAmount) < 10 && (currentX + moveAmount) > -10)
        {
            transform.Translate(speed * Time.deltaTime * moveDirection);
        }
        
    }
    
    
}
