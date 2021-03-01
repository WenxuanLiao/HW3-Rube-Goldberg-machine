using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Color floorcolor;
    SpriteRenderer myRender;
    void Start()
    {
        myRender = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "ball" || other.gameObject.name == "ball (1)")
        {
            myRender.color = floorcolor;
            Camera.main.fieldOfView = 80;
        }
    }
}
