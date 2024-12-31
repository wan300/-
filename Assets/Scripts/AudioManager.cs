
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource bgmSource; // 拖动Audio Source组件到这个字段

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "End 1")
        {
            Destroy(this.gameObject);
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
        if(sceneName != "Main"&&sceneName != "Main2"&&sceneName != "Main3"&&sceneName != "Main4"&&sceneName != "Main5")
        {
            StopBGM();
        }
         if(sceneName == "Main"||sceneName == "Main2"||sceneName == "Main3"||sceneName == "Main4"||sceneName == "Main5")
        {
            PlayBGM();
        }
        if(sceneName == "End"||sceneName == "End 1")
        {
            Destroy(this.gameObject);
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
