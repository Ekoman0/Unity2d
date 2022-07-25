using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EveGir : MonoBehaviour
{
  
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.Find("Un") == null && GameObject.Find("Un 2") == null)
        {
            if (other.gameObject.tag == "Player")
            {
                
                    
                    SceneManager.LoadScene(2);
                
                
            }
        }
        if (GameObject.Find("Scythe") == null)
        {
            if (other.gameObject.tag == "Player")
            {

                
                SceneManager.LoadScene(3);


            }
        }
    }
}
