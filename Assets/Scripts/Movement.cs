using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float jumpHeight = 6f;
    public bool grounded;
    private float movementSpeed = 8f;
    private float maximumSpeed = 8f;

    private void Start(){
        rb.freezeRotation = true;
    }

    void FixedUpdate(){
        if(Input.GetKey("w") && grounded == true){
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            grounded = false;
        }
        if(Input.GetKey("d")){
            rb.AddForce(new Vector2(movementSpeed, 0));
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, maximumSpeed);
        }
        if(Input.GetKey("a")){
            rb.AddForce(new Vector2(-movementSpeed, 0));
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, maximumSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        grounded = true;
    }

    void OnCollisionExit2D(Collision2D collision){
        grounded = false;
    }
}
