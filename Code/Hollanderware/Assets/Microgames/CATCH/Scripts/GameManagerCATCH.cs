using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerCATCH : MonoBehaviour
{
    public static bool playerWin = false;
    public static bool playerLose = false;

    void OnGUI()
    {
        if (playerWin == true)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Yay! Menu"))
            {
                RestartLevel();
            }
        }
        if (playerLose == true)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), " Aw... Menu"))
            {
                RestartLevel();
            }
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0); // 3 is the scene for CATCH
        Time.timeScale = 1.0f;
    }
}
