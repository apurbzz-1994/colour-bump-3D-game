using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObjectLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int greenColorChannel = Random.Range(10,255);
        GetComponent<MeshRenderer>().material.color = new Color32(100, (byte)greenColorChannel, 200, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
