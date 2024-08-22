using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehavior : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotationStatic();
        ResetGravity();
    }

    void RotationStatic() 
    {
         if (WorldRotation.isRotating)
        {
            zeroGravity();
            setVelocityZero();
        }
    }

    public void ResetGravity() {
        if (!WorldRotation.isRotating) {
            rb.gravityScale = 1;
        } 
    }

    public void zeroGravity() {
        rb.gravityScale = 0;
    }
   
    public float showGravity() {
        return rb.gravityScale;
    }
    public void setVelocityZero() {
        rb.velocity = Vector2.zero;
    }
}

