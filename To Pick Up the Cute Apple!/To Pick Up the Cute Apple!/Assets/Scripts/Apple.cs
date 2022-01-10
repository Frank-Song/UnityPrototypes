using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void move()
    {
        transform = new Vector2(transform.position.x, transform.position.y + speed*-1);
    }
}
