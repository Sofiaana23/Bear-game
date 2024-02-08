using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public IntData score;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI highscoretext;
    public float timer;
    public TextMeshProUGUI timertext;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        score.value = 0;
    }

    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        timer = (float)System.Math.Round(timer, 2);
        if (timer <= 0)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
        timertext.text = timer.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.value.ToString();
        highscoretext.text = score.value2.ToString();

        if (score.value2 < score.value)
        {
            score.value2 = score.value;
        }
    }

    public void Restart()
    {
        string Level = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(Level);
    }
}
