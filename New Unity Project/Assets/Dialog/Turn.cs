using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
    }

    private void FixedUpdate()
    {
        

        
        if (Player.horizontal < 0)
        {
            sr.flipX = true;
        }
        else if (Player.horizontal > 0)
        {
            sr.flipX = false;
        }
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
