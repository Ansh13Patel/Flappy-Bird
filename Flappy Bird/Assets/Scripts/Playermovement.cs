using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(5 * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.Space)) {
            transform.position += new Vector3(0, 20*Time.deltaTime, 0);
        }
        
    }
}
