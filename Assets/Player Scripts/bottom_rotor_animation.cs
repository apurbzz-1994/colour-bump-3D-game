using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottom_rotor_animation : MonoBehaviour
{
    // Start is called before the first frame update
    float xValue;
    float zValue;

    float constantSpeed = 10;

    float rotorSpeed = 3f;

    
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        xValue = Input.GetAxis("Vertical") * Time.deltaTime * constantSpeed;
        zValue = Input.GetAxis("Horizontal") * Time.deltaTime * constantSpeed * -1;

        if(xValue != 0 || zValue != 0){
            // basically anytime the player is not pressing the move buttons
            transform.Rotate(0,0,rotorSpeed);
        }
        
    }
}
