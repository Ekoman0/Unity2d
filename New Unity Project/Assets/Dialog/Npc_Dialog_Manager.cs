using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_Dialog_Manager : MonoBehaviour
{
    public List<Dialog> npc_dialoglar = new List<Dialog>();
    public int currentdialog;
    public int currentdialogText;
    public Sprite npc_icon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextDialog()
    {
        if (currentdialog < npc_dialoglar.Count - 1)
        {
            currentdialog = currentdialog + 1;
            
            
        }
    }
  
}
