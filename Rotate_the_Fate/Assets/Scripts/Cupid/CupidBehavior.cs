using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupidBehavior : MonoBehaviour
{
    private CupidCollision coll;
    private Rigidbody2D rb;
    private Animator anim;
    [Space]
    [Header("Stats")]
    public float speed = 10.0f;
    public float acceleration = 100f;//intertance move   
    public float deceleration = 1000f;//intertance stop
    public float jumpForce = 10f;
    public bool mTowardRight = true;
    // Start is called before the first frame update
    void Start()
    {
        mTowardRight = true;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CupidCollision>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;//所有活物都要锁定！
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x, y);

        Walk(dir);
        Jump(Vector2.up);
        //Flip();
        Fall();
    }

    private void Walk(Vector2 dir)
    {
       if(!WorldRotation.isRotating) {
            rb.velocity = new Vector2(dir.x * speed, rb.velocity.y);
            bool slimeHasXAxisSpeed = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;
            anim.SetBool("Walk", slimeHasXAxisSpeed);

            if(dir.x > 0f) {
                 transform.localRotation = Quaternion.Euler(0, 0, 0);
                 mTowardRight = true;
            }
            if(dir.x < 0f) {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                mTowardRight = false;
            }
        }
    }

    private void Jump(Vector2 dir) 
    {
        if (Input.GetKeyDown(KeyCode.Space) && coll.onGround) {
            anim.SetBool("Jump", true);
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.velocity += dir * jumpForce;
            bool slimeHasYAxisSpeed = Mathf.Abs(rb.velocity.y) > Mathf.Epsilon;
        }
    }

    private void Flip() {
        bool slimeHasXAxisSpeed = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;
        if(slimeHasXAxisSpeed) {
            if (rb.velocity.x > 0f) {
                //mTorwardRight = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            } 
            if (rb.velocity.x < 0f) {
                //mTorwardRight = false;
                transform.localRotation  = Quaternion.Euler(0, 180, 0);
            }
        }
    }

    private void Fall() {
        if (rb.velocity.y < 0.1f) {
            anim.SetBool("Jump", false);
        }
    }
}

