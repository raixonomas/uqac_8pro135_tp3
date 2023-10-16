using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class GlobalMusicPlayer : Singleton<GlobalMusicPlayer>
{
    private AudioSource _audioSource;

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    public void UpdateVolume(float vol) =>
        _audioSource.volume = vol;
}
