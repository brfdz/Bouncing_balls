using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollect : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bucket"))
        {
            Destroy(gameObject);
        }
    }
}
