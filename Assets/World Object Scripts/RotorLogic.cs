using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorLogic : MonoBehaviour
{
    // Start is called before the first frame update

    public bool winningColorFound;

    void Start()
    {
        winningColorFound = false;   
    }

    // Update is called once per frame
    void Update()
    {   
        if(winningColorFound){
            transform.Rotate(4f,0,0);
        }
        
    }


}
