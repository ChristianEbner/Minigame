using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    enum Scenes { Start, SampleScene, GameOver };

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadWelcomeScene()
    {
        SceneManager.LoadScene((int)Scenes.Start);
    }

    public void LoadMainGameScene()
    {
        SceneManager.LoadScene((int)Scenes.SampleScene);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene((int)Scenes.GameOver);
    }
}