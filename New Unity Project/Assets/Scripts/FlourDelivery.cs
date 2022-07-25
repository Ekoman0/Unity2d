using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlourDelivery : MonoBehaviour
{
     
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag =="Fýrýn")
        {
            
            Destroy(MoveFlour.newflour.gameObject);
            Player.speed = 200;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
