﻿/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour {

    private Text scoreText;

    private void Awake() {
        scoreText = transform.Find("scoreText").GetComponent<Text>();
    }

    private void Update() {
        scoreText.text = GameHandler.GetScore().ToString();
    }
}
