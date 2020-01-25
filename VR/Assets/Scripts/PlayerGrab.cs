using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject ball;
    public GameObject hand;
    public Vector3 move;
    public bool grabed;
    Collider coll;
    Rigidbody rb;
    public float handPower;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        move = new Vector3(0.34f, -0.6f, 0.72f);
        grabed = false;
        handPower = 1500;
        rb = ball.GetComponent<Rigidbody>();
        coll = ball.GetComponent<SphereCollider>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GrabBowlingBall()
    {
        grabed = true;
        coll.isTrigger = true;
        rb.useGravity = false;
        ball.transform.SetParent(hand.transform);
        ball.transform.localPosition = hand.transform.localPosition + move;
    }

    public void ThrowBowlingBall()
    {
        grabed = false;
        coll.isTrigger = false;
        rb.useGravity = true;
        ball.transform.SetParent(null);
        rb.AddForce(hand.transform.forward * handPower);
    }
}
