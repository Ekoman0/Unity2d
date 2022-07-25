using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBoom : MonoBehaviour
{
    public AudioSource Source;
    public AudioClip BoomSound;
    public GameObject Explosive;
    public GameObject ExplosiveDot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Rock")
        {

            Instantiate(Explosive, ExplosiveDot.gameObject.transform.position, Quaternion.identity);
            Source.PlayOneShot(BoomSound);
            Destroy(other.gameObject);
            Destroy(this.gameObject);

           

        }
    }
}
