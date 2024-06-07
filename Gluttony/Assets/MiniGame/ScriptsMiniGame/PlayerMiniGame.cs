using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMiniGame : MonoBehaviour
{

    [SerializeField] float speed = 10f;
    Rigidbody2D rb2d; 
    SpriteRenderer spriteRenderer;
    
    Animator anim; 

    private bool wasRunning;
    private bool grounded = true;


    void Awake(){
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent< Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    void Update(){
      
       if( Input.GetAxis("Horizontal") != 0){
           Run();
        }
        else if(wasRunning){
            wasRunning = false;
            anim.SetBool("isRun", false);
        }
        
    }

    void Run(){

       wasRunning = true;

        float deltaX = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        anim.SetBool("isRun", grounded);    //вкл аним, если на земле
        gameObject.transform.Translate(deltaX, 0, 0);

        Flip();
    }
    
    void Flip(){
        if(Input.GetAxis("Horizontal") < 0) 
        {
            spriteRenderer.flipX = false; 
            anim.SetTrigger("isRunMiniGame");
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            spriteRenderer.flipX = true; 
             anim.SetTrigger("isRunMiniGame");
        }
    }

}
