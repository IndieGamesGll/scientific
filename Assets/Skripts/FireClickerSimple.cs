using UnityEngine;
using UnityEngine.SceneManagement;

public class FireClickerSimple : MonoBehaviour
{
    [SerializeField] private ParticleSystem _fire;
    [SerializeField] private ParticleSystem _spark;
    [SerializeField] private GameObject _winText, _gameOverText;
    private bool GameStoped = false;

    void Start()
    {
        _fire.GetComponent<ParticleSystem>();
        _spark.GetComponent<ParticleSystem>();
    }

    void FixedUpdate()
    {
        if (!GameStoped)
        {
            _fire.startSize += 0.005f;
            _fire.startLifetime += 0.0025f;
            _fire.startSpeed += 0.00255f;
        }
        if (_fire.startSize >= 6)
        {
            GameOver();
        }
        if (_fire.startSize <= 0.05f)
        {
            Win();
            _spark.startSize = 0;
        }

    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        _gameOverText.SetActive(true);
        GameStoped = true;
    }
    public void Win()
    {
        Debug.Log("Game Won");
        _winText.SetActive(true);
        GameStoped = true;
    }
    public void Click()
    {
        _fire.startSize -= 0.1f;
        _fire.startLifetime -= 0.05f;
        _fire.startSpeed -= 0.05f;

        //Spark.startSpeed -= 0.025f;
        //Spark.startLifetime -= 0.025f;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
