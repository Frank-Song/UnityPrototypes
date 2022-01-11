using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("text_score").GetComponent<Text>().text = "111";        
    }

    // Update is called once per frame
    void Update()
    {
        synchronization();
    }

    private void synchronization()
    {
        // GameObject.Find("game_UI/image_background_ui/text_score").GetComponent<Text>().text = "111";
    }
}
