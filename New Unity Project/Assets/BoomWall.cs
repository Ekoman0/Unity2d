using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomWall : MonoBehaviour
{
    public GameObject duvar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Wizard2" ) == null)
        {
            Destroy(duvar.gameObject);

        }
    }
}
