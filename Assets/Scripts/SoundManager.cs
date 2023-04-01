using UnityEngine;
using Random = UnityEngine.Random;

public class SoundManager : Singleton<SoundManager>
{
    public Boolean IsSfxOn;
    [Header("Play non audio source specific SFX using this one, will pause playing ones if a new one arrives.")]
    public AudioSource defaultSFXAudioSource;

    public void PlaySfx(AudioSource src, AudioClip clip)
    {
        if (!IsSfxOn.Value)
        {
            return;
        }

        src.clip = clip;
        src.Play();
    }
    public void PlaySfx(AudioSource src, AudioClip[] clips)
    {
        this.PlaySfx(src, clips[Random.Range(0, clips.Length)]);
    }

    public void PlaySfx(AudioClip clip)
    {
        this.PlaySfx(this.defaultSFXAudioSource, clip);
    }
    public void PlaySfx(AudioClip[] clips)
    {
        this.PlaySfx(this.defaultSFXAudioSource, clips);
    }

}