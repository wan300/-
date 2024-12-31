using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTimeMode : MonoBehaviour
{
    public void Startnormalmode(){
       SceneManager.LoadScene("NormalMode");
   }
   void Start()
   {
   // ScoreManager.score = 0;   
   }
}
