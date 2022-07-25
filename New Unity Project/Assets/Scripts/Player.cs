using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public int ciftzipla = 2;
    public static Vector3 scale;
    public static bool LookRight = true;
    bool zipla = true;
    public float JumpForce;
    Rigidbody2D rb;
    Animator PlayerAnimator;
    public static float speed= 200f;
    public static float horizontal;




    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        
        PlayerAnimator.SetFloat("Speed",Mathf.Abs(horizontal));

        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(horizontal * Time.deltaTime * speed, rb.velocity.y, 0);

        if (Input.GetKey(KeyCode.D) && LookRight ==false )
        {
            //cevir();
        }
        if (Input.GetKey(KeyCode.A) && LookRight == true)
        {
            //cevir();
        }
    }

    void Update()
    {
       // karakterHareket();
        if (Input.GetKeyDown(KeyCode.Space)&& ciftzipla > 0)
        {
            ciftzipla = ciftzipla -1;
            PlayerAnimator.SetBool("Jump", true);
            rb.AddForce(new Vector2(0, JumpForce));
            //zipla = false;

        }
       

      

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag== "zemin" && PlayerAnimator.GetBool("Jump"))
        {
            PlayerAnimator.SetBool("Jump", false);
            zipla = true;
            ciftzipla = 2;
        }
    }
   
  
}
