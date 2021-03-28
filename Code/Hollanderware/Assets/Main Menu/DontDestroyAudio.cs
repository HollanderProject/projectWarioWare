using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        // If music is already playing, destroy any other instances
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        // Keep playing
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // If the scene is not one of the title menus, stop playing the menu music
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.buildIndex != 0 && currentScene.buildIndex != 1 && currentScene.buildIndex != 2)
            Destroy(this.gameObject);
    }
}
