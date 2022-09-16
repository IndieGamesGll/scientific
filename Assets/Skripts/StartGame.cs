using UnityEngine;

public class StartGame : MonoBehaviour
{

    void Update()
    {
        Time.timeScale = 0f;
    }
    public void ResumeTime()
    {
        Time.timeScale = 1f;
    }
}
