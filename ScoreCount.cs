using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreCount : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private string scoreName;

    private int score;
    
    public int Score
    {

        set { score = value; }

    }

    private void Start()
    {

        scoreText.text = ScoreValue(score, scoreName);

    }
    private void StartScoreCount()
    {

        StartCoroutine(CountScore());

    }

    private string ScoreValue(int score, string name)
    {
        string scoreName = name + score;
        return scoreName;
    }



    public IEnumerator CountScore()
    {
        while (score != 0)
        {
            
            score--;
            scoreText.text = ScoreValue(score, scoreName);
            scoreManager.totalScoreValue++;
            scoreManager.totalScoreText.text = ScoreValue(scoreManager.totalScoreValue, "Total Score: ");
            yield return null;

        }

    }


}
