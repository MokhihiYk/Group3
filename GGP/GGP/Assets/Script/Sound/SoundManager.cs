using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    float masterVolumePercent = 1;
    float sfxVolumePrecent = 1;
    float musicVoulmePercent = 1;

    AudioSource[] musicSources;
    int activeMusicSourceIndex;

    void Awake() {
        musicSources = new AudioSource[2];
        for (int i = 0; i < 2; i++) {
            GameObject newMusicSource = new GameObject("Music Sources " + (i + 1));
            musicSources[i] = newMusicSource.AddComponent<AudioSource>();
            newMusicSource.transform.parent = transform;
        }
    }

    public void PlayMusic(AudioClip clip, float fadeDuration = 1) {
        activeMusicSourceIndex = 1 - activeMusicSourceIndex;
        musicSources[activeMusicSourceIndex].clip = clip;
        musicSources[activeMusicSourceIndex].Play();

        StartCoroutine(AnimateMusicCrossfade(fadeDuration));
    }

    public void PlaySound(AudioClip clip, Vector3 pos) {
        AudioSource.PlayClipAtPoint(clip, pos, sfxVolumePrecent * masterVolumePercent);
    
    }

    IEnumerator AnimateMusicCrossfade(float duration) {
        float percent = 0;

        while (percent < 1) {
            percent += Time.deltaTime * 1 / duration;
            musicSources[activeMusicSourceIndex].volume = Mathf.Lerp(0, musicVoulmePercent * musicVoulmePercent, percent);
            musicSources[1-activeMusicSourceIndex].volume = Mathf.Lerp( musicVoulmePercent * musicVoulmePercent,0, percent);
            yield return null;
        }
    }

}
