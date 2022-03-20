using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public static float maxTime=1f;
    float timer;

    public static  float maxY=1f;
    public static float minY=-1f;
    float randY;

    // Start is called before the first frame update
    void Start()
    {
        //InstantiatePrefab();
    }

    

    // Update is called once per frame
    void Update()
    {
        if(GameManager.gameHasStarted == true)
        {
            timer += Time.deltaTime;
            if (timer >= maxTime)
            {
                InstantiatePrefab();
                timer = 0;
            }

        }




    }

    public void InstantiatePrefab()
    {
        randY = Random.Range(minY, maxY);
        GameObject pipes = Instantiate(prefab);
        pipes.transform.position = new Vector2(
            transform.position.x,
            randY
            );
    }

}
