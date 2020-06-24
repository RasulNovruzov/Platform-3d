using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeleft;
    public GameObject theScore;
    public int timeCalc;
    public int scoreCalc;

    void OnTriggerEnter()
    {
        timeCalc = MyTimer.ScoreShow * 100;
        timeleft.GetComponent<Text>().text = "Time left: " + MyTimer.ScoreShow;
        theScore.GetComponent<Text>().text = "Score: " + MyScore.currentScore;
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeleft.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }

}
