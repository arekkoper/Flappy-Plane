using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private Text score;
    private int points;

    private void Start()
    {
        score = GetComponent<Text>();
        StartCoroutine(ScoreIncrement());
    }

    void Update()
    {
        if(score.name == "FinishText")
        {
            score.text = "Zdobyte punkty: " + PlayerPrefs.GetInt("points");
        }
        else
        {
            score.text = "Punkty: " + points;
        }
    }

    IEnumerator ScoreIncrement()
    {
        if(SceneManager.GetActiveScene().name == "game")
        {
            for (int i = 0; true; i++)
            {
                yield return new WaitForSeconds(1f);
                points++;
                PlayerPrefs.SetInt("points", points);
            }
        }
    }
}
