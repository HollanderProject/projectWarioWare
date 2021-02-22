using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonInteraction : MonoBehaviour
{

    int noseClicks = 0;

    void Update ()
    {   
        
    }

    private void OnMouseDown()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            

        }
        */
        noseClicks++;
        Debug.Log("Nose click number: " + noseClicks);
        
        if (noseClicks >= 3)
        {
            Debug.Log("Win condition has been met");
            ChangeScene("winScene");
        }
    }
    
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
