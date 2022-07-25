using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Dialog 1", menuName ="Dialog And Quest/dialog")]
public class Dialog : ScriptableObject
{
    public int ID;
    public List<DialogText> Dialoglar = new List<DialogText>();
    
  
}
