using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Button scoreButton;
    public TextMeshProUGUI totalScoreText;

    [SerializeField] private ScoreCount[] scoreCounters;

    public int totalScoreValue;

    void Awake()
    {
        for (int i = 0; i < scoreCounters.Length; i++)
        {
            int num = i + 1;
            scoreCounters[i].Score = 500 * 2 * i;

        }


        scoreButton.onClick.AddListener(StartScoreCount);

    }

    private void StartScoreCount()
    {

        StartCoroutine(SequenceCount());

    }


    private IEnumerator SequenceCount()
    {

        for (int i = 0; i < scoreCounters.Length; i++)
        {
            yield return StartCoroutine(scoreCounters[i].CountScore());
        }

    }


}
