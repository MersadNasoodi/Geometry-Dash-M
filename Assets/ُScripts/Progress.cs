using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public Transform player;
    public Transform startLevel;
    public Transform endLevel;

    private void Update()
    {
        float totalDistance = endLevel.position.x - startLevel.position.x;
        float playerDistance = player.position.x - startLevel.position.x;

        float playerProgress = Mathf.Clamp01(playerDistance / totalDistance);

        int mainProgress = Mathf.RoundToInt(playerProgress * 100);

        Debug.Log(mainProgress);

        int savedProgress = PlayerPrefs.GetInt("HighScore");

        if (mainProgress > savedProgress)
        {
            PlayerPrefs.SetInt("HighScore", mainProgress);
            PlayerPrefs.Save();
        }

    }
}
