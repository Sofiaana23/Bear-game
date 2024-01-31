using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public IntData score;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI highscoretext;
    public float timer;
    public TextMeshProUGUI timertext;

    // Start is called before the first frame update
    void Start()
    {
        score.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log("you starved");
        }
        timertext.text = timer.ToString();
        scoretext.text = score.value.ToString();
        highscoretext.text = score.value2.ToString();

        if (score.value2 < score.value)
        {
            score.value2 = score.value;
        }
    }
    
}
