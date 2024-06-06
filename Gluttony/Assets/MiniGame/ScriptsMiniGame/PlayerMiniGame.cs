using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMiniGame : MonoBehaviour
{

    [SerializeField] float speed = 10f;
    Rigidbody2D rb2d; 
    
    [SerializeField]   Animator anim; 

    void Awake(){
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent< Animator>();
    }
    void FixedUpdate(){

        //anim.SetTrigger("isRunMiniGame");
      
        float deltaX = speed * Input.GetAxis("Horizontal");
        
        //rb2d.AddForce(new Vector2(deltaX, 0) * speed);
        rb2d.velocity = new Vector2(deltaX, rb2d.velocity.y);

        //rb2d.velocity = new Vector2(speed * input, rb2d.velocity.y);

        // float deltaX = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        //gameObject.transform.Translate(deltaX, 0, 0);
        
    }
    
}
