using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject platform;
    public void NewGame()
    {
        platform.GetComponent<MenuPlatform>().startMovement = true;
        Invoke("startGame", 5f);
        
    }

    void startGame()
    {
        SceneManager.LoadScene(1);
    }
}
