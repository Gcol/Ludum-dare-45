using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour
{

   	private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = 0;
        float y = 0;
        rigidBody.velocity = new Vector3(0,0,0);
        if (Input.GetKey("left"))
        {
            x -= 50;
        }
        if (Input.GetKey("right"))
        {
            x += 50;
        }
        if (Input.GetKey("up"))
        {
            y += 50;
        }
        if (Input.GetKey("down"))
        {
            y -= 50;
        }
        rigidBody.velocity = new Vector3(x, y, 0);
    }
}
