using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreHelper : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int _score = 0;

    public int Score
    {
        get
        {
            return _score;
        }
    }
    public void AddScore(int score)
    {
        _score += score;
        scoreText.text = string.Format("Score: {0}", _score);
        gameOverText.text = string.Format("{0} points", _score);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            Debug.LogWarning("scoreText wasnt add!!!!!");
        }
        scoreText.text = string.Format("Score: {0}", _score);
        gameOverText.text = string.Format("{0} points", _score);
    }

    //Update -x-
    //нет необходимости перезаписывать очки каждый кадр, так как изменить очки можно лишь только через метод 
    //AddScore, где и можна перезаписать очки
}
