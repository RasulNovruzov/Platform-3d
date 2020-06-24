using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScore : MonoBehaviour
{
    public GameObject scoreBox;
    public static int currentScore;
    public int internalScore;

    void Update()
    {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;
    }
}
