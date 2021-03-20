using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMicrogame : MonoBehaviour
{
    public static int browse = 2, 
        catchGame = 3, 
        climb = 4, 
        connect = 5, 
        cut = 6, 
        herd = 7, 
        nudge = 8,
        organize = 9, 
        poke = 10, 
        shoot = 11, 
        spot = 12;

    public void PlayBROWSE()
    {
        SceneManager.LoadScene(browse);
    }

    public void PlayCATCH()
    {
        SceneManager.LoadScene(catchGame);
    }

    public void PlayCLIMB()
    {
        SceneManager.LoadScene(climb);
    }

    public void PlayCONNECT()
    {
        SceneManager.LoadScene(connect);
    }

    public void PlayCUT()
    {
        SceneManager.LoadScene(cut);
    }

    public void PlayHERD()
    {
        SceneManager.LoadScene(herd);
    }

    public void PlayNUDGE()
    {
        SceneManager.LoadScene(nudge);
    }

    public void PlayORGANIZE()
    {
        SceneManager.LoadScene(organize);
    }

    public void PlayPOKE()
    {
        Debug.Log("POKE is currently unavailable");
        //SceneManager.LoadScene(poke);
    }

    public void PlaySHOOT()
    {
        SceneManager.LoadScene(shoot);
    }

    public void PlaySPOT()
    {
        Debug.Log("SPOT is currently unavailable");
        //SceneManager.LoadScene(spot);
    }
}
