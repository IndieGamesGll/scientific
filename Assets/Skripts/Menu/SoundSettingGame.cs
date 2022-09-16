using UnityEngine;

public class SoundSettingGame : MonoBehaviour
{
    public static SoundSettingGame Instance;
    [SerializeField] private float _musicVolume;
    [SerializeField] private float _soundEffectsVolume;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Load();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Load()
    {
        _musicVolume = PlayerPrefs.GetFloat("MusicVolume", 0.3f);
        _soundEffectsVolume = PlayerPrefs.GetFloat("SfxVolume", 0.3f);
    }
    public float MusicVolume
    {
        get { return _musicVolume; }
        set
        {
            PlayerPrefs.SetFloat("MusicVolume", value);
            _musicVolume = value;
        }
    }

    public float SoundEffectsVolume
    {
        get { return _soundEffectsVolume; }
        set
        {
            PlayerPrefs.SetFloat("SfxVolume", value);
            _soundEffectsVolume = value;
        }
    }

}
