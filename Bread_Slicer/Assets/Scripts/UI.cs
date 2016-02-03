using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    private int _score = 0;
    private int _time = 60;
    [SerializeField]
    private Text _scoreText;
    [SerializeField]
    private Text _timerText;
    [SerializeField]
    private Text _gameOverText;
    [SerializeField]
    private GameObject _spawner;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(TimerCountDown());
    }

    public void UpdateScore()
    {
        _score += 10;
        _scoreText.text = "Score: " + _score;

    }

    IEnumerator TimerCountDown()
    {
        yield return new WaitForSeconds(1);
        _time--;
        _timerText.text = "Time Left: " + _time;
        if (_time == 0)
        {
            Destroy(_spawner);
            _gameOverText.text = "Time's Up" + "\n" + "Your Score is: " + _score;
        }
        else
        {
            StartCoroutine(TimerCountDown());
        }

    }
}
