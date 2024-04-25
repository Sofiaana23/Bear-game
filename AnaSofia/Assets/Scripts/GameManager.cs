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
    public FloatData timer;
    public TextMeshProUGUI timertext;
    public GameObject gameOverScreen;
    public GameObject[] Rain;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        score.value = 0;
        timer.value = 10f;
        InvokeRepeating("RainManager", 6f, 2f);
    }

    void FixedUpdate()
    {
        timer.value -= Time.deltaTime;
        timer.value = (float)System.Math.Round(timer.value, 2);
        if (timer.value <= 0)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
        timertext.text = timer.value.ToString();
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

    void RainManager()
    {
        int i = Random.Range(0, Rain.Length);
        Rain[i].SetActive(!Rain[i].activeSelf);
    }
}
