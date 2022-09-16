using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WaterCklickerWithTimer : MonoBehaviour
{


    private float _seconds = 60;
    private bool _timerStoped = false;
    [SerializeField] private Text _timer;
    [SerializeField] private GameObject _winText, _gameOverText;
    [SerializeField] private GameObject _waterPlane;
    [SerializeField] private GameObject _waterParticle;

    void Update()
    {
        if (!_timerStoped)
        {
            _seconds -= Time.deltaTime;
        }
        if (_seconds >= 0)
        {
            Debug.Log("Mtav");
            _timer.text = Mathf.Round(_seconds).ToString();

        }
        if (_seconds <= 0)
        {
            _timerStoped = true;
            GameOver();
        }
        if (_waterPlane.transform.position.y <= -0.01)
        {
            _waterParticle.SetActive(false);
            Win();
        }


    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        _gameOverText.SetActive(true);
    }
    public void Win()
    {
        _timerStoped = true;
        Debug.Log("Game Won");
        _winText.SetActive(true);

    }
    public void Click()
    {

        Vector3 Offset = new Vector3(0, -0.01f, 0);
        _waterPlane.transform.Translate(Offset);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}