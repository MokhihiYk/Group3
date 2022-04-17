using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager current;

    [Header("Íæ¼Ò")]
    public AudioClip hurtClip;   //done
    public AudioClip ShootClip; //done

    [Header("­h¾³")]
    public AudioClip MusicClip;
    public AudioClip FightMusicClip;

    AudioSource FightMusicSource;
    AudioSource musicSource;
    AudioSource effectSource;

    float masterVolumePercent = 1f;
    float sfxVolumePercent = 1f;
    float musicVolumePercent = 1f;


    private void Awake() {
        current = this;

        effectSource = gameObject.AddComponent<AudioSource>();
        musicSource = gameObject.AddComponent<AudioSource>();
        FightMusicSource = gameObject.AddComponent<AudioSource>();


        DontDestroyOnLoad(gameObject);

        StopMusic();
        Music();
    }

    public static void PlayerGetHurt() {
        current.effectSource.clip = current.hurtClip;
        current.effectSource.volume = 0.2f;
        current.effectSource.Play();

    }

    void Music()
    {
        current.musicSource.clip = current.MusicClip;
        current.musicSource.loop = true;
        current.musicSource.volume = 0.2f;
        current.musicSource.Play();  
    }

    void FightMusic()
    {
        
        current.FightMusicSource.clip = current.FightMusicClip;
        current.FightMusicSource.loop = true;
        current.FightMusicSource.volume = 0.2f;
        current.FightMusicSource.Play();
        StopMusic();
    }
    public static void StopMusic()      //Start Ghost will still play TitleBGM plz fix it
    {
        current.FightMusicSource.Stop();
        current.musicSource.Stop();
    }


    public void PlaySound(AudioClip clip, Vector3 pos)
    {   
        if(clip!=null)
            AudioSource.PlayClipAtPoint(clip, pos, sfxVolumePercent * masterVolumePercent);
    }

}
