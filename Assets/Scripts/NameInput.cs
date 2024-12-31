using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public GameObject popupPanel; // 弹窗面板
    public InputField nameInputField; // 输入字段
    public Button submitButton; // 提交按钮
     int score;
    void Start()
    {
        // 初始化
        popupPanel.SetActive(true);
        // 假设游戏开始时初始化分数
        score = ScoreManager.score;
        StartCheckFinish.IsfinishGame=true;
        // 为提交按钮添加点击事件
        submitButton.onClick.AddListener(SubmitName);
    }

    // 显示弹窗的方法
    public void ShowPopup()
    {
        popupPanel.SetActive(true);
    }

    // 提交名字的方法
    private void SubmitName()
    {   
       
        string playerName = nameInputField.text;
        Debug.Log("玩家输入的名字是: " + playerName);
        // 可以在这里添加其他逻辑，比如保存名字到PlayerPrefs或者发送到服务器
        string scoreFilePath = Application.persistentDataPath + "/score.txt"; // 使用持久化数据路径
        try{
            File.AppendAllText(scoreFilePath, playerName +" ");
        }
        catch (Exception e)
        {
            Debug.LogError("保存分数时发生错误: " + e.Message);
        }
        
        SaveScoreToFile();
        // 提交后关闭弹窗
        popupPanel.SetActive(false);
    }
     public void SaveScoreToFile()
    {
        string scoreFilePath = Application.persistentDataPath + "/score.txt"; // 使用持久化数据路径
        string scoreText = score.ToString() + Environment.NewLine; // 添加换行符

        try
        {
            File.AppendAllText(scoreFilePath, scoreText);
            Debug.Log("分数已成功保存到文件");
            Debug.Log("Score file path: " + scoreFilePath);
        }
        catch (Exception e)
        {
            Debug.LogError("保存分数时发生错误: " + e.Message);
        }
    }
}
