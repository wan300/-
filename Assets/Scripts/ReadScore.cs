using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScoreReader : MonoBehaviour
{
    public ScrollRect scrollView; // 拖拽你的Scroll View到这个字段
    public Text contentText; // 拖拽你的Text组件到这个字段

    void Start()
    {
        string filePath = Application.persistentDataPath + "/score.txt";
        string content = ReadFileContent(filePath);
        DisplayContentInScrollView(content);
    }

    // 读取文件内容
    string ReadFileContent(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            List<PlayerScore> scores = new List<PlayerScore>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                {
                    scores.Add(new PlayerScore { Name = parts[0], Score = score });
                }
            }

            // 根据分数降序排序
            scores = scores.OrderByDescending(s => s.Score).ToList();

            // 构建格式化的分数排名字符串
            string formattedScores = "\n";
            int rank = 1;
            foreach (var score in scores)
            {
                formattedScores += $"{rank++}\t{score.Name}\t{score.Score}\n";
            }

            return formattedScores;
        }
        else
        {
            Debug.LogError("File not found: " + filePath);
            return "File not found.";
        }
    }

    // 将内容显示在Scroll View的Text组件中
    void DisplayContentInScrollView(string content)
    {
        if (contentText != null)
        {
            contentText.text = content;
            // 更新内容大小以适应文本
            LayoutRebuilder.ForceRebuildLayoutImmediate(contentText.GetComponent<RectTransform>());
        }
        else
        {
            Debug.LogError("Text component not assigned.");
        }
    }

    // 用于存储玩家名字和分数的结构
    private struct PlayerScore
    {
        public string Name;
        public int Score;
    }
}
