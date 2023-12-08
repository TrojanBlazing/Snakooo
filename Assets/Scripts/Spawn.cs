using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D food;
    

    void Start()
    {
        RandomSpawn();

    }

   
    void Update()
    {
        
    }
    void RandomSpawn()
    {
        Bounds b = this.food.bounds;
        float x = Random.Range(b.min.x, b.max.x);
        float y = Random.Range(b.min.y, b.max.y);
        this.transform.position = new Vector3(x, y, 0);
    }



     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            RandomSpawn();
        }
    }
}
