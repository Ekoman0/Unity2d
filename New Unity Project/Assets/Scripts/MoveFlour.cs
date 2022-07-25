using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MoveFlour : MonoBehaviour
{
    public UnityEvent UnBýrakildi;
    public static GameObject newflour;
    public GameObject Playeer;
    public Transform Dot;
    public GameObject Flour;
    // Start is called before the first frame update
   

    void Start()
    {
        if(UnBýrakildi == null)
        {
            UnBýrakildi = new UnityEvent();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    private void OnTriggerStay2D(Collider2D collision)
    {
       
        if (Input.GetKeyDown(KeyCode.F))
        {
            

            //this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
             
            newflour =Instantiate(Flour, Dot.position,Quaternion.identity);            
            newflour.transform.parent = Playeer.transform;
            Player.speed = 125f;
            UnBýrakildi.Invoke();
            Destroy(this.gameObject);

           
        }

       
    }
}
