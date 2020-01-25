using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Press the space key in Play Mode to switch to the Bounce state.

public class OpenDoor : MonoBehaviour
{
    private Animation anim;
    private bool opened;
    public GameObject player;

    public void Start()
    {
        anim = GetComponent<Animation>();
        opened = false;
    }

    public void Update()
    {
        // anim.Play("Complete");
    }

    public void OpenNorth()
    {
        /*anim.Play("Door_Open");
        yield WaitForSeconds(1);
        anim.Play("Door_Close");*/
        if (!opened)
        {
            StartCoroutine(MyCoroutine(0f, 2f, 25f));
            opened = !opened;
        }
    }

    public void OpenSouth()
    {
        if (!opened)
        {
            StartCoroutine(MyCoroutine(0f, 2f, -25f));
            opened = !opened;
        }
    }

    public void OpenWest()
    {
        if (!opened)
        {
            StartCoroutine(MyCoroutine(-25f, 2f, 0f));
            opened = !opened;
        }
    }

    public void OpenEast()
    {
        if (!opened)
        {
            StartCoroutine(MyCoroutine(25f, 7.5f, 0f));
            opened = !opened;
        }
    }

    IEnumerator MyCoroutine(float x, float y, float z)
    {
        anim.Play("Door_Open");
        yield return new WaitForSeconds(3);
        player.transform.position = new Vector3(x, y, z);
        yield return new WaitForSeconds(3);
        anim.Play("Door_Close");
        yield return new WaitForSeconds(3);
        opened = !opened;
        //Opening();
    }

    /*public bool Opening()
    {
        return false;
    }*/
}
