using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAI : MonoBehaviour
{

    public GameObject apple;
    public float speed;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        speed = 150f;
        direction = 1;
        transform.position = new Vector2(500,520);
    }

    // Update is called once per frame
    void Update()
    {
        dropApple();
        checkDirection();
        move();
    }

    private void move()
    {
        transform.position = new Vector2(transform.position.x + speed*direction*Time.deltaTime, transform.position.y);
    }

    private void checkDirection()
    {
        if(transform.position.x <= 60||transform.position.x >= 820){
            direction = direction*-1;
        }
    }

    private void dropApple()
    {
        float num = Random.Range(0f,5000f);
        if(num <= 10){
            GameObject instance = (GameObject)Instantiate(apple, transform.position, transform.rotation);
        }
    }
}
