using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class ScenePass : MonoBehaviour
{
    public void gostart()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Title");
        SceneManager.LoadSceneAsync("title");
    }
    public void gomain()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Game");
        SceneManager.LoadSceneAsync("Game");
    }
    public void goend()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Result");
        SceneManager.LoadSceneAsync("Result");
    }
}
