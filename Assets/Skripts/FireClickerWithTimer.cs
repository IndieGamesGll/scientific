using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FireClickerWithTimer : MonoBehaviour
{


    private float _seconds = 25;
    private bool _timerStoped = false;
    [SerializeField] private Text _timer;
    [SerializeField] private ParticleSystem _fire;
    [SerializeField] private ParticleSystem _spark;
    [SerializeField] private GameObject _winText, _gameOverText;

    void Start()
    {
        _fire.GetComponent<ParticleSystem>();
        _spark.GetComponent<ParticleSystem>();
    }


    void Update()
    {
        if (!_timerStoped)
        {
            _seconds -= Time.deltaTime;
        }
        if (_seconds >= 0)
        {

            _timer.text = Mathf.Round(_seconds).ToString();

        }
        if (_seconds <= 0)
        {
            _timerStoped = true;
            GameOver();
        }
        if (_fire.startSize <= 0)
        {
            Win();
            _spark.startSize = 0;

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
        _fire.startSize -= 0.05f;
        _fire.startLifetime -= 0.025f;
        _fire.startSpeed -= 0.025f;

        _spark.startSpeed -= 0.025f;
        _spark.startLifetime -= 0.025f;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}