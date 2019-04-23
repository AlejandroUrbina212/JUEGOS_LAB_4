using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject player;

    public GameObject currPlayer;

    public GameObject capsule1;
    public GameObject capsule2;
    public GameObject capsule3;
    public GameObject capsule4;


    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 0.0f)
            Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (player && !currPlayer)
            {
                currPlayer = Instantiate(player, new Vector3((float)-6.5, 2, -10), Quaternion.identity);
                //Delete all the capsules in the scene
                DestroyCapsules();
                InstantiateCapsules();


            }
                
        }    

    }

    void DestroyCapsules()
    {
        GameObject[] capsules = GameObject.FindGameObjectsWithTag("Capsula");
        foreach (GameObject capsule in capsules)
        {
            GameObject.Destroy(capsule);
        }
    }
    void InstantiateCapsules()
    {
        Instantiate(capsule1, new Vector3((float)-6.5, 1, 5), Quaternion.identity);
        Instantiate(capsule2, new Vector3((float)-1.5, 1, -9), Quaternion.identity);
        Instantiate(capsule3, new Vector3(3, 1, 0), Quaternion.identity);
        Instantiate(capsule4, new Vector3((float)7.5, 1, 10), Quaternion.identity);

    }
}
