using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObjectLogic : MonoBehaviour
{
    // Start is called before the first frame update

    // colour array
    public Color32[] objectColors;

    public Color32 winningColor; 

    public GameObject rotor;

    int totalColors = 4;
    void Start()
    {
        int greenColorChannel = Random.Range(10,255);
        GetComponent<MeshRenderer>().material.color = new Color32(100, (byte)greenColorChannel, 200, 255);


        objectColors = new Color32[totalColors];

        winningColor = new Color32(74,221,70, 255);

        // populating the colour array
        populateColorArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        // grab the current color of the object
        Color32 currentColor = GetComponent<MeshRenderer>().material.color;

        // checking to see if currentColor is the same as winning color
        if(currentColor.r == winningColor.r && currentColor.g == winningColor.g && currentColor.b == winningColor.b){
            // it is the winning color, so rotate the fans
            Debug.Log("You've bumped into the winning color!");
            rotor.GetComponent<RotorLogic>().winningColorFound = true;
        }
        else{
            // pick a random colour from the array and change the mesh color to that
            int randomIndex = Random.Range(0,objectColors.Length);

            // change mesh colour to the selected random color
            GetComponent<MeshRenderer>().material.color = objectColors[randomIndex];
        }
    }

    void populateColorArray(){

        // place the winning color in the first array position
        objectColors[0] = winningColor;

        // generate a random color and place them in the other array positions
        for(int i = 1; i < objectColors.Length; i++){
            // generate a random number for all the channels
            int redColorChannel = Random.Range(0,255);
            int greenColorChannel = Random.Range(0,255);
            int blueColorChannel = Random.Range(0,255);

            // place a color in the array
            objectColors[i] = new Color32((byte)redColorChannel, (byte)greenColorChannel, (byte)blueColorChannel, 255);
        }


       

        
    }
}
