using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
    public Color floorcolor;
    SpriteRenderer myRender;
    private Rigidbody2D rb;
    private bool runonce;


    // Start is called before the first frame update
    void Start()
    {
        myRender = gameObject.GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        runonce = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = 1;
        }
        
    }
     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name =="floor")
        {
            myRender.color = floorcolor;
            Camera.main.fieldOfView = 100;
            if (runonce == false)
            {
                rb.AddForce(new Vector3(800, 0, 0));
                runonce = true;
            }
        }
    }
}
