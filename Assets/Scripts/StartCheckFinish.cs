using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCheckFinish : MonoBehaviour
{   
    public static bool IsfinishGame;

    // Start is called before the first frame update
    void Start()
    {
        if(IsfinishGame){
            SceneManager.LoadScene("Start 1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
