using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuEvent : MonoBehaviour
{
    [SerializeField] private Button _level2;
    [SerializeField] private Button _level3;
    private int _levelComplete;
    private void Start()
    {
        _levelComplete = PlayerPrefs.GetInt("LevelComplete");
        // _level2.interactable = false;
        // _level3.interactable = false;

        switch (_levelComplete)
        {
            case 1:
                _level2.interactable = true;
                break;
            case 2:
                _level2.interactable = true;
                _level3.interactable = true;
                break;
        }

    }


    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void ResetProgress()
    {
        _level2.interactable = false;
        _level3.interactable = false;
        PlayerPrefs.DeleteAll();
    }

}
