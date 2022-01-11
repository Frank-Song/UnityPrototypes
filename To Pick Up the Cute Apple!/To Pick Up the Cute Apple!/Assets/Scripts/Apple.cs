using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apple : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        move();
        reachBottom();
    }

    private void move()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed*-1*Time.deltaTime);
    }

    private void reachBottom()
    {
        if(transform.position.y <= 50){
            Destroy(gameObject);
            GameObject.Find("basket").GetComponent<GameControl>().HP -= 1;
            GameObject.Find("basket").GetComponent<GameControl>().textHP.text = "x"+GameObject.Find("basket").GetComponent<GameControl>().HP.ToString();
        }
    }
}
