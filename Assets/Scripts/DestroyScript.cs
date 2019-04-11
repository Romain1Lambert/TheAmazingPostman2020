using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private int points;

    private int ConvertPosToScore(float posY)
    {
        return  10 - Convert.ToInt32(posY);
    }


    private void OnMouseDown()
    {
        points = ConvertPosToScore(gameObject.transform.position.y);
        Destroy(gameObject);
        ScoreManager.score += points;
    }
}
