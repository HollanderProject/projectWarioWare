using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneViaButtons : MonoBehaviour
{
    public static int titleScreen = 0;
    public static int microGameSelector = 2;
    public static int tutorialScreen = 14;


    public void exitButton()
    {
        SceneManager.LoadScene(titleScreen);
    }

    public void collectionsButton()
    {
        SceneManager.LoadScene(15);
    }
    
    public void microGameButton()
    {
        SceneManager.LoadScene(microGameSelector);
    }

    public void tutorialButton()
    {
        SceneManager.LoadScene(tutorialScreen);
    }


}
