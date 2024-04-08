using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlatform : MonoBehaviour
{
    public Vector3 moveVector;
    private Vector3 startVector;
    private Vector3 direction;
    public float moveSpeed = 3f; // Speed of movement
    public bool startMovement = false;

    void Start()
    {
        startVector = transform.position;
    }
    void Update()
    {
        // Move the object linearly along the specified direction
        if (startMovement)
        {
            direction= (moveVector - transform.position);
            if (Vector3.Distance(transform.position, moveVector) <= 0.1)
            {
                moveVector = startVector;
            }
            transform.position = Vector3.MoveTowards(transform.position, moveVector, moveSpeed * Time.deltaTime);
            //Lerp(startVector, moveVector, Mathf.PingPong(Time.unscaledTime * moveSpeed, 1));
        }
    }
}
