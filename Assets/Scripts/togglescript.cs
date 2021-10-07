using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglescript : MonoBehaviour
{
    bool matToggle;
    Material m;

    void Update()
    {
        m = GetComponent<Renderer>().material;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            matToggle = true;
            
            if(matToggle == true)
            {
                m.color = Color.red;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            matToggle = false;
            if(matToggle == false)
            {
                m.color = Color.white;
            }
        }
    }
}
