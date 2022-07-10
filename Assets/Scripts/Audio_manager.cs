//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Audio_manager : MonoBehaviour
//{
//    public static Audio_manager _instance;

//    private AudioSource bgm, sound;
//    // Start is called before the first frame update
//    private void Awake()
//    {
//        _instance = this;
//        bgm = transform.Find("bgm_menu").GetComponent<AudioSource>();
//        sound = transform.Find("bgm").GetComponent<AudioSource>();
//        //获取到保存声音大小
//        //bgm.volume = PlayerPrefs.GetFloat(Const.Music,0.5f);
//        //sound.volume = PlayerPrefs.GetFloat(Const.Sound, 0.5f);


//    }
//    public void PlayMusic(AudioClip audioClip)
//    {
//        bgm.clip = audioClip;
//        bgm.loop = true;
//        bgm.Play();
//    }
//    public void PlaySound(AudioClip audioClip)
//    {
//        sound.PlayOneShot(audioClip);
//    }
//    public void OnMusicVolumeChange(float value)
//    {
//        sound.volume = value;
//    }

//}
