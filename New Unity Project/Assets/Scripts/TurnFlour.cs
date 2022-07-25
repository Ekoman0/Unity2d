using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnFlour : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {



        if (Player.horizontal < 0)
        {
            this.gameObject.transform.position = new Vector3(-2,(float)-2.33, 0);
        }
        else if (Player.horizontal > 0)
        {
            this.gameObject.transform.position = new Vector3((float)0.3199997, (float)-2.33, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
