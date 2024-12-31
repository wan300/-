using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgmManager : MonoBehaviour
{
     public static BgmManager instance;

    public AudioSource bgmSource; // 拖动Audio Source组件到这个字段

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
        else
        {
            Destroy(gameObject);
        }
    }

    // 在游戏开始时播放BGM
    void Start()
    {
        PlayBGM();
    }
    void Update()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if(sceneName != "Start 1"&&sceneName != "Ranking"&&sceneName != "End 1"&&sceneName != "Start"){
            StopBGM();
             Destroy(this.gameObject);
        }
         if(sceneName == "Start 1"||sceneName == "Ranking"||sceneName == "End 1")
        {
            PlayBGM();
        }
        
    }

    // 播放BGM的方法
    public void PlayBGM()
    {
        if (!bgmSource.isPlaying)
        {
            bgmSource.Play();
        }
    }
    public void StopBGM()
    {
        if (bgmSource.isPlaying)
        {
            bgmSource.Stop();
        }
    }
}
