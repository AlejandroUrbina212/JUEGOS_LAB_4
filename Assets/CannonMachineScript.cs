using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMachineScript : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPos.x = startPos.x + Mathf.Sin(Time.time);
        newPos.y = startPos.y;
        newPos.z = startPos.z;
        transform.position = newPos;
    }
}
