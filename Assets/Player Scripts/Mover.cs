using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update

    float constantSpeed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * constantSpeed;
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * constantSpeed * -1;

        transform.Translate(xValue, 0, zValue);
    }
}
