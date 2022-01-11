using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public int score;
    public int HP;
    public Text textScore;
    public Text textHP;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        HP = 3;
        textScore.text = score.ToString();
        textHP.text = "x"+HP.ToString();
        transform.position = new Vector2(400, 100);
    }

    // Update is called once per frame
    void Update()
    {
        move();
        gameOver();
    }

    private void move()
    {
        if(Input.mousePosition.x <= 820&&Input.mousePosition.x >= 60){
            transform.position = new Vector2(Input.mousePosition.x, transform.position.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score += 100;
        if(collision.gameObject.tag == "collection"){
            score += 100;
            textScore.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }

    private void gameOver()
    {
        if(HP <= 0){
            textScore.text = "Game Over!";
            Time.timeScale = 0;
        }
    }
}
