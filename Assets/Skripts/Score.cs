using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int _test = 0;
    public static int _test2 = 0;
    public static int _test3 = 0;
    public static int _test4 = 0;
    [SerializeField] private Text _testText;
    private int _result = 0;
    [SerializeField] private GameObject _win;
    private void Start()
    {
        _testText.text = "Пройдено испытаний " + _result + " из 4";
        LoadData();
        if (_result == 4)
        {
            _win.SetActive(true);
        }
    }
    public void AddScore()
    {
        if (PlayerPrefs.HasKey("test"))
            _test = 1;
        else
            _test++;
        _testText.text = "Пройдено испытаний " + _test + " из 4";

    }

    public void AddScore2()
    {
        if (PlayerPrefs.HasKey("test2"))
            _test2 = 1;
        else
            _test2++;
        _testText.text = "Пройдено испытаний " + _test2 + " из 4";

    }
    public void AddScore3()
    {
        if (PlayerPrefs.HasKey("test3"))
            _test3 = 1;
        else
            _test3++;
        _testText.text = "Пройдено испытаний " + _test3 + " из 4";

    }
    public void AddScore4()
    {
        if (PlayerPrefs.HasKey("test4"))
            _test4 = 1;
        else
            _test4++;
        _testText.text = "Пройдено испытаний " + _test4 + " из 4";

    }
    public void LoadData()
    {
        if (PlayerPrefs.HasKey("test") || PlayerPrefs.HasKey("test2") || PlayerPrefs.HasKey("test3") || PlayerPrefs.HasKey("test4"))
        {

            _test = PlayerPrefs.GetInt("test");
            _test = PlayerPrefs.GetInt("test2");
            _test = PlayerPrefs.GetInt("test3");
            _test = PlayerPrefs.GetInt("test4");
            _result = PlayerPrefs.GetInt("test") + PlayerPrefs.GetInt("test2") + PlayerPrefs.GetInt("test3") + PlayerPrefs.GetInt("test4");
            _testText.text = "Пройдено испытаний " + _result + " из 4";
        }

    }
}
