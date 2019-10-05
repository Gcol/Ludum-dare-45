using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour
{

   	private Rigidbody2D rigidBody;
    public float vitesse = 1;
    public float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
     	rigidBody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = 0;
        float y = 0;
        if (Input.GetKey("left"))
        {
            x -= 100;
        }
        if (Input.GetKey("right"))
        {
            x += 100;
        }
        if (Input.GetKey("up"))
        {
            y += 100;
        }
        if (Input.GetKey("down"))
        {
            y -= 100;
        }
        rigidBody.velocity = new Vector2(x * vitesse, y * vitesse);
        if (x == 100 && y == 100)
            rigidBody.rotation = 225;
        else if (x == -100 && y == 100)
            rigidBody.rotation = -45;    
        else if (x == 100 && y == -100)
            rigidBody.rotation = 135;
        else if (x == -100 && y == -100)
           rigidBody.rotation = 45;
        else if (x == 100)
            rigidBody.rotation = 180;
        else if (x == -100)
            rigidBody.rotation = 0;
        else if (y == -100)
            rigidBody.rotation = 90;
        else if (y == 100)
            rigidBody.rotation = 270;
    }
}
