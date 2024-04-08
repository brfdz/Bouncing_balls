using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatfromMovement : MonoBehaviour
{
    public float startPosX;
    public float endPosX;
    public float posY;
    public float moveSpeed = 2.0f;
    private float posZ;
    private Vector3 startVector;
    private Vector3 endVector;

    // Start is called before the first frame update
    void Start()
    {

        posZ = gameObject.transform.position.z;
        startVector = new Vector3(startPosX, posY, posZ);
        endVector = new Vector3(endPosX, posY, posZ);
        transform.position = startVector;
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startVector, endVector, Mathf.PingPong(Time.time * moveSpeed, 1));
    }
    
    
    
}
