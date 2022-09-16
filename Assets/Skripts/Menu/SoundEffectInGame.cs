using UnityEngine;

public class SoundEffectInGame : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().volume = SoundSettingGame.Instance.SoundEffectsVolume;
    }
}
