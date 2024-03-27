using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Ball"))
            Destroy(gameObject);
    }
  
}
