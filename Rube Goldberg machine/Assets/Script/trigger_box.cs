using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_box : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer myRender;
    public Color floorcolor;
    public static bool isTrigger;
    public GameObject secondball;
 
    private Rigidbody2D rb;
    void Start()
    {
        isTrigger = false;
        myRender = gameObject.GetComponent<SpriteRenderer>();
        rb = secondball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Dom (4)")
        {
            myRender.color = floorcolor;
            rb.AddForce(new Vector3(0, 1200, 0));
            isTrigger = true;
        }
    }
}
