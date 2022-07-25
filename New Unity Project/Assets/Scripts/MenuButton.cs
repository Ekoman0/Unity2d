using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
