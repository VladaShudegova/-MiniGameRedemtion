using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMiniGame : MonoBehaviour
{

    [SerializeField] float speed = 10f;
    Rigidbody2D rb2d; 
    SpriteRenderer spriteRenderer;
    
    [SerializeField]   Animator anim; 


    void Awake(){
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent< Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    void Update(){

        //anim.SetTrigger("isRunMiniGame");
      
        float deltaX = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        Flip();
        gameObject.transform.Translate(deltaX, 0, 0);
        
    }

    void Flip(){
        if(Input.GetAxis("Horizontal") < 0) 
            spriteRenderer.flipX = true; 
        else if (Input.GetAxis("Horizontal") > 0)
            spriteRenderer.flipX = false; 
    }

}
