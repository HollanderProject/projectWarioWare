using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToLevelSelect : MonoBehaviour
{
    public static int levelSelect = 1;

    public void ExitLoadLevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }
}
