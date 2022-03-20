using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovementToLeft : MonoBehaviour
{
    public static float speed=6f;

    float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    
    void Update()
    {
      
      transform.position += Vector3.left * speed * Time.deltaTime;
   
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
