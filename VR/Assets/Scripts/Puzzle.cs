using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject puzzle;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //puzzle.GetComponent<MeshRenderer>().material = mat1;
    }

    public void PutPiece()
    {
        transform.gameObject.SetActive(false);
        puzzle.GetComponent<MeshRenderer>().material = mat;
    }
}
