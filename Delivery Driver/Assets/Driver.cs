using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Variables
    [SerializeField] float steerSpeed = 300;
    [SerializeField] float moveSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0,0,45);
    }

    // Update is called once per frame
    void Update()
    {        
        //transform.Rotate(0,0,45);
        //transform.Rotate(0,0,steerSpeed);
        //transform.Translate(0,moveSpeed,0);
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);

        // Time.deltatime how long each frame took to execute
        
    }
}
