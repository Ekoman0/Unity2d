using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class Explore : MonoBehaviour
{
    public  UnityEvent �imKe�if;
    // Start is called before the first frame update
    void Start()
    {
        if (�imKe�if == null)
        {
            �imKe�if = new UnityEvent();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && collision.gameObject.CompareTag("Player"))
        {
            �imKe�if.Invoke();
        }
        
    }
    
}
