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
        if (playerWin || playerLose)
        {
            //if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Done"))
            //{
            //    RestartLevel();
            //}
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(3); // 3 is the scene for CATCH
        Time.timeScale = 1.0f;
    }
}
