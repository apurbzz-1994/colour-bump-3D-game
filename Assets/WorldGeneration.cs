using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    // Start is called before the first frame update
    
    // number of cubes to be populated
    public int objectNumber = 10;

    // game object to be cloned
    public GameObject bluePrintCube;

    // plane for parent
    public GameObject planeReference; 

    // dynamically determining the xPos and zPos ranges
    public Vector3 topLeftCornerVertex;
    public Vector3 topRightCornerVertex;
    public Vector3 bottomLeftCornerVertex;

    
    void Start()
    {

        findCornerVertices();
        
        // populating clones of the blueprint cube
        for(int i = 0; i < objectNumber; i++){
           float xPos = Random.Range(topLeftCornerVertex.x, topRightCornerVertex.x);
           float zPos = Random.Range(topLeftCornerVertex.z, bottomLeftCornerVertex.z);
           float yScale = Random.Range(0.2f,1f);
           //int greenColorChannel = Random.Range(10,255);

           GameObject oneWorldObject = Instantiate(bluePrintCube, planeReference.transform, false);
           
           // setting position for the object
           oneWorldObject.transform.position = new Vector3(xPos, 0, zPos);
           
           // a random scaling towards the sky
           oneWorldObject.transform.localScale = new Vector3(0.2f,yScale,0.2f);

           // assigning a random colour
           //oneWorldObject.transform.Find("Object").gameObject.GetComponent<MeshRenderer>().material.color = new Color32(100, (byte)greenColorChannel, 200, 255);
        }
        
    }

    void findCornerVertices(){
        // fetching all the coordinates (local) of the vertices in the plane mesh
        List<Vector3> LocalVertices = new List<Vector3>(GetComponent<MeshFilter>().mesh.vertices);

        /* transforming local coordinates into world coordinates
         for three of the four vertices.  
        */
        topLeftCornerVertex = transform.TransformPoint(LocalVertices[0]);
        topRightCornerVertex = transform.TransformPoint(LocalVertices[10]);
        bottomLeftCornerVertex = transform.TransformPoint(LocalVertices[110]);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0.1f,0);   
    }
}
