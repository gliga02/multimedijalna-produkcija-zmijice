using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour {

    private Text scoreText;

    private void Awake() {
        scoreText = transform.Find("scoreText").GetComponent<Text>();

        Score.OnHighscoreChange += Score_OnHighscoreChange;
        UpdateHighscore();
    }

    private void Score_OnHighscoreChange(object sender, System.EventArgs e){
        UpdateHighscore();
    }

    private void Update() {
        scoreText.text = Score.GetScore().ToString();
    }

    private void UpdateHighscore(){
        int highscore = Score.GetHighscore();
        transform.Find("highscoreText").GetComponent<Text>().text = "HIGHSCORE\n" + highscore.ToString();
    }
}
