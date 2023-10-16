using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryCooseLevel : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }
    
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }
}
