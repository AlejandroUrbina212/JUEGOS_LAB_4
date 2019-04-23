using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public static int deaths = 0;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));
        RaycastHit hitInfo;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.tag == "enemy")
                {
                    Destroy(hitInfo.collider.gameObject);
                    DeathMade();
                }
            }
        }
    }
    public static int getDeaths()
    {
        return deaths;
    }
    private void DeathMade()
    {
        deaths += 1;
    }
}
