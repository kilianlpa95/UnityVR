using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlCollider : MonoBehaviour
{
    public GameObject levelPassed1;
    public GameObject levelReturn1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "BowlingBall")
        {
            levelPassed1.transform.gameObject.SetActive(true);
            levelReturn1.transform.gameObject.SetActive(false);
        }
    }
}
