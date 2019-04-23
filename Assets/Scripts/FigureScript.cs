using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureScript : MonoBehaviour
{
    private Rigidbody rb;
    private int force = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo))
            rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
           
    }

    private void OnMouseEnter()
    {
        //Fetch the Renderer from the GameObject
        gameObject.GetComponent<Renderer>().material.color = new Color(0.1f, 0.1f, 0.5f, 0.1f);
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
    }

}   
