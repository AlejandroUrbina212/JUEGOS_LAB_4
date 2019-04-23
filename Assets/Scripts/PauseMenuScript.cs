using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))

            if (isPaused) Continue();
            else Pause();
    }

    public void Pause()
    {
        transform.Find("PauseMenuPanel").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        isPaused = true;

    }

    public void Continue()
    {
        transform.Find("PauseMenuPanel").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = false;

    }

    public void ChangeScene(string _newScene)
    {
         Time.timeScale = 1.0f;
        SceneManager.LoadScene(_newScene);
    }


}
