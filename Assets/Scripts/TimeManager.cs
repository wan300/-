using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // 添加对 UI 命名空间的引用

public class TimeManager : MonoBehaviour
{
    public Text timeText; // 引用 UI 文本组件
    public  static float countdownTime ; // 倒计时总时间，单位为秒
    public static bool ispause ; //  是否暂停
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {if(ispause){
        currentTime = countdownTime; // 初始化当前时间为倒计时总时间
        ispause = false;
    }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime; // 每帧减少时间
            UpdateTimeText(); // 更新 UI 文本
            countdownTime = currentTime;
        }
        else
        {
            currentTime = 0; // 确保时间不会变成负数
            UpdateTimeText();
            countdownTime = currentTime;
            // 倒计时结束后的逻辑
            if(SceneManager.GetActiveScene().name=="Main5"){
                SceneManager.LoadScene("End 1");
            }
            else
            SceneManager.LoadScene("End");
        }
    }

    void UpdateTimeText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60); // 计算分钟
        int seconds = Mathf.FloorToInt(currentTime % 60); // 计算秒数
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // 更新文本显示
    }
    public float GetTime()
    {
       return currentTime;
    }
}