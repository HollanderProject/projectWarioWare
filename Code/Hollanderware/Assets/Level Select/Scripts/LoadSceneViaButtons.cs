using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneViaButtons : MonoBehaviour
{
    public static int titleScreen = 0;
    public static int microGameSelector = 2;

    public void exitButton()
    {
        SceneManager.LoadScene(titleScreen);
    }

    public void collectionsButton()
    {
        Debug.Log("Current version does not support collections");
    }
    
    public void microGameButton()
    {
        SceneManager.LoadScene(microGameSelector);
    }

}
