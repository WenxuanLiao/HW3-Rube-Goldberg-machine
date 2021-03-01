using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run_away : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger_box_2.isTrigger_1==true)
        {
            transform.position = transform.position + new Vector3(-0.01f,0,0);
            Camera.main.fieldOfView = 120;
        }
    }
}
