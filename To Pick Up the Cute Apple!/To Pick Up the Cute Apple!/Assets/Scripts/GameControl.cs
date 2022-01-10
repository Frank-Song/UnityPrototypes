using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public int score;
    public int HP;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        HP = 3;
        transform.position = new Vector2(400, 100);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        if(Input.mousePosition.x <= 820&&Input.mousePosition.x >= 60){
            transform.position = new Vector2(Input.mousePosition.x, transform.position.y);
        }
    }
}
