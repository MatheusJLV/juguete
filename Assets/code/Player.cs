using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform trans;
    private Rigidbody rb;
    public int jump;
    // Start is called before the first frame update
    void Start()
    {
        trans = this.transform;
        rb = GetComponent<Rigidbody>();
        //jump = 80;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { // Move left
            rb.AddForce(Vector3.right* -100);
            /*
            var newPos = trans.position;
            newPos.x -= 1;
            trans.position = newPos;
            */

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        { // Move Right
            rb.AddForce(Vector3.right * 100);
            /*
            var newPos = trans.position;
            newPos.x += 1;
            trans.position = newPos;
            */

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        { // Move down
            rb.AddForce(Vector3.forward * -100);
            /*
            var newPos = trans.position;
            newPos.z -= 1;
            trans.position = newPos;
            */

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        { // Move up
            rb.AddForce(Vector3.forward * 100);
            /*
            var newPos = trans.position;
            newPos.z += 1;
            trans.position = newPos;
            */
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*jump);
        }
    }
}
