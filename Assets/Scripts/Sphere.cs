using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sphere : MonoBehaviour
{
    private static float force = 7;
    private static int powerUps = 0;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            Jump();
           
        
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }
    }
    private void Jump()
    {
        if (rb)
        {   
            if(Mathf.Abs(rb.velocity.y) < 0.005f)
            //Para mover hacia arriba con un impulso en el eje y
            rb.AddForce(0, force/2, 0, ForceMode.Impulse);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lava_Section") {
            if (collision.gameObject)
            {   
                if (GetPowerUps() != 4)
                {
                    Destroy(gameObject);
                }
            }

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Capsula")
        {
            if (other.gameObject)
            {
                addPowerUp();
                Destroy(other.gameObject);

            }
        }

    }
    public static int GetPowerUps()
    {
        return powerUps;
    }
    private void addPowerUp()
    {
        powerUps += 1;
    }
}
