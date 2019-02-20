using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Camera cam;
    public GameObject duckie;
    public float timeleft;
    public Text timerText;


    private float maxWidth;

    // Use this for initialization
    void Start()
    {

        if (cam == null)
        {
            cam = Camera.main;
        }

        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float duckieWidth = duckie.GetComponent<Renderer>().bounds.extents.x;
        maxWidth = targetWidth.x - duckieWidth;
        timerText.text = "Time Left:\n" + Mathf.RoundToInt(timeleft);
    }

    private void FixedUpdate()
    {
        timeleft -= Time.deltaTime;
        if (timeleft < 0)
        {
            timeleft = 0;
            SceneManager.LoadScene("GameOver");
        }
        timerText.text = "Time Left:\n" + Mathf.RoundToInt(timeleft);

    }


}
