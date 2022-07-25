using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Player_Dialog_Controller : MonoBehaviour
{   
    public GameObject EntryCave;

    public GameObject ExitCave;
    public GameObject Train;
    public GameObject TrainPosition;
    public GameObject WallDontMove;
    public Npc_Dialog_Manager npc;
    public bool inside;
    public bool talking;
    public bool beginning = true;
    public GameObject DialogUI;
    public Text Title;
    public Text Context;
    public  TextMeshProUGUI PressF;
    //public Image Face;
    public Button btn;
    public bool die;
    





    void Start()
    {
        btn.onClick.AddListener(NextDialog);
        
    }
    // Update is called once per frame
    void Update()
    {

        
        
        if (inside && Input.GetKeyDown(KeyCode.F))
        {
            DialogUI.SetActive(!DialogUI.activeSelf);
            talking = !talking;
          
        }
        else if (!inside)
        {
            DialogUI.SetActive(false);
            talking = false;
        }
        if (talking)
        {
            Title.text = npc.npc_dialoglar[npc.currentdialog].Dialoglar[npc.currentdialogText].Speaker.ToString() + ";";
            Context.text = npc.npc_dialoglar[npc.currentdialog].Dialoglar[npc.currentdialogText].context;
            //Face.sprite = npc.npc_icon;
        }
        if (inside && beginning)
        {
            
            DialogUI.SetActive(true);
            talking = !talking;

            SpriteRenderer[] renderChildren = GetComponentsInChildren<SpriteRenderer>();
            int i;
            for (i = 0; i < renderChildren.Length; ++i)
            {
                renderChildren[i].enabled = false;
            }
            //this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            



        }
        else if (!inside && !beginning)
        {
            DialogUI.SetActive(false);
            talking = false;
        }
        if (inside && die)
        {

            DialogUI.SetActive(true);
            talking = !talking;                    

        }
        else if (!inside && !die)
        {
            DialogUI.SetActive(false);
            talking = false;
        }
        if (die == false)
        {
            GameObject.Find("OraklýAzrail").transform.DOMoveX(TrainPosition.transform.position.x, 7);
            Destroy(GameObject.Find("OraklýAzrail").GetComponent<BoxCollider2D>());


        }


    }

    public void NextDialog()
    {
        if(npc.currentdialogText < npc.npc_dialoglar[npc.currentdialog].Dialoglar.Count - 1)
        {
            npc.currentdialogText++;
        }
        else
        {
            npc.currentdialogText = 0;
            DialogUI.SetActive(false);
            beginning = false;
            die = false;
            //this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
            SpriteRenderer[] renderChildren = GetComponentsInChildren<SpriteRenderer>();
            int i;
            for (i = 0; i < renderChildren.Length; ++i)
            {
                renderChildren[i].enabled = true;
            }
            Destroy(WallDontMove);

        }
    }

    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Npc_Dialog_Manager>())
        {
            PressF.text = "Etkileþime Geçmek Ýçin F'ye Basýn.";
            npc = collision.gameObject.GetComponent<Npc_Dialog_Manager>();
            inside = true;
        }
        if (collision.gameObject.tag == "Flour")
        {
            PressF.text = "Etkileþime Geçmek Ýçin F'ye Basýn.";
        }
       

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        PressF.text = " ";
        inside = false;
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            PressF.text = "Anamenü'ye Dönmek Ýçin F'ye Basýn.";
            if (Input.GetKey(KeyCode.F))
            {
                
                SceneManager.LoadScene(0);
            }
        }
       
        if (collision.gameObject.tag == "Kol" && GameObject.Find("Train") != null)
        {
            PressF.text = "Etkileþime Geçmek Ýçin F'ye Basýn.";
            if (Input.GetKey(KeyCode.F))
            {
                Train.transform.DOMoveX(TrainPosition.transform.position.x,5);

              
               
            }
        }
        if (collision.gameObject.tag == "EntryCave")
        {
            PressF.text = "Maðaraya Girmek Ýçin F'ye Basýn.";
            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.transform.position = new Vector2(EntryCave.transform.position.x, EntryCave.transform.position.y);

            }
        }
        if (collision.gameObject.tag == "ExitCave" && GameObject.Find("Scythe") == null)
        {
            PressF.text = "Maðaradan Çýkmak Ýçin F'ye Basýn.";
            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.transform.position = new Vector2(ExitCave.transform.position.x, ExitCave.transform.position.y);

            }
        }
        if (collision.gameObject.tag == "Scythe")
        {
            PressF.text = "Týrpaný Almak Ýçin F'ye Basýn.";
            if (Input.GetKey(KeyCode.F))
            {
                Destroy(collision.gameObject);

            }
        }
    }
}

