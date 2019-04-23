using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PersistentCanvasScript : MonoBehaviour
{
    private bool isPaused = false;
    private int counter = 0;
    GameObject coinsText;
    Text text = null;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        counter = ManagerScript.getDeaths();
        coinsText = GameObject.Find("KillsText");
        text = coinsText.GetComponent<Text>();
        text.text = "Kills :  " + counter.ToString();
        
    }

    public void Reload(string _newScene){
            SceneManager.LoadScene(_newScene);
    }

    
}
