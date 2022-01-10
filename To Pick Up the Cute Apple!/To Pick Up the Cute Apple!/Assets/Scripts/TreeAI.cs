using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAI : MonoBehaviour
{

    public float speed;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
        direction = 1;
        transform.position = new Vector2(500,520);
    }

    // Update is called once per frame
    void Update()
    {
        checkDirection();
        transform.position = new Vector2(transform.position.x + speed*direction, transform.position.y);
    }

    private void checkDirection()
    {
        if(transform.position.x <= 60||transform.position.x >= 820){
            direction = direction*-1;
        }
    }

    private void dropApple()
    {
        //先睡觉吧
    }
}
