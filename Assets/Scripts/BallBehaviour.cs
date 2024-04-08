using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public GameObject manager;
    public int pointBucket;
    public int pointFall;
    public int lifePoint;

   
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        //if ball is out of the screen
        if (gameObject.transform.position.x < -11 || gameObject.transform.position.x > 11)
        {
            Destroy(gameObject);
        }
    }
    

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("bucket"))
        {
            manager.GetComponent<SpawnManager>().score += pointBucket;
            manager.GetComponent<SpawnManager>().life += lifePoint;
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("floor"))
        {
            manager.GetComponent<SpawnManager>().score += pointFall;
            Destroy(gameObject);
        }
        
    }
    
    
    
}
