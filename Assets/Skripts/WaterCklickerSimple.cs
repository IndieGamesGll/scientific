using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterCklickerSimple : MonoBehaviour
{


    [SerializeField] private GameObject _winText, _gameOverText;
    [SerializeField] private GameObject _waterPlane;
    [SerializeField] private GameObject _waterParticle;


    private bool _gameStoped = false;

    void FixedUpdate()
    {
        if (_waterPlane.transform.position.y >= 3.3)
        {
            GameOver();
        }

        if (_waterPlane.transform.position.y <= -0.01)
        {
            _waterParticle.SetActive(false);
            Win();
        }
        if (!_gameStoped)
        {
            Vector3 Offset = new Vector3(0, +0.001f, 0);
            _waterPlane.transform.Translate(Offset);
        }
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        _gameOverText.SetActive(true);
        _gameStoped = true;
    }
    public void Win()
    {
        _gameStoped = true;
        Debug.Log("Game Won");
        _winText.SetActive(true);

    }
    public void Click()
    {

        Vector3 Offset = new Vector3(0, -0.02f, 0);
        _waterPlane.transform.Translate(Offset);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}