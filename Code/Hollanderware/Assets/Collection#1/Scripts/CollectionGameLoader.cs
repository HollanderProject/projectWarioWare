using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionGameLoader : MonoBehaviour
{
    public void loadGame(int gamenumber)
    {
        Debug.Log("Loading new game....");
        SceneManager.LoadScene(gamenumber,LoadSceneMode.Additive);

    }
}
