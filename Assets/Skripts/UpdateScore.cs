using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    private Score _score;
    private void Awake()
    {
        _score = FindObjectOfType<Score>();
    }
    public void ScoreUpdate()
    {
        _score.AddScore();
        PlayerPrefs.SetInt("test", Score._test);
    }

    public void ScoreUpdate2()
    {
        _score.AddScore2();
        PlayerPrefs.SetInt("test2", Score._test2);
    }
    public void ScoreUpdate3()
    {
        _score.AddScore3();
        PlayerPrefs.SetInt("test3", Score._test3);
    }
    public void ScoreUpdate4()
    {
        _score.AddScore4();
        PlayerPrefs.SetInt("test4", Score._test4);
    }
}
