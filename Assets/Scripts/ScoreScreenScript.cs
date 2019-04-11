using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScreenScript : MonoBehaviour
{
    Text text;                      

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    private void Start()
    {
        text = GameObject.Find("Score")?.GetComponent<Text>();
        if (text != null)
            text.text =  ScoreManager.score.ToString();
    }
}
