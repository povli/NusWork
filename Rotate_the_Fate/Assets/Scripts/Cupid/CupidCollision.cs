using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupidCollision : MonoBehaviour
{
    [Header("Layers")]
    public LayerMask groundLayer;

    [Space]
    public bool onGround;

    [Header("Collision")]
    public float collisionRadius = 1f;
    public Vector2 bottomOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         onGround = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, collisionRadius, groundLayer);
    }

      void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        var positions = new Vector2[] { bottomOffset};

        Gizmos.DrawWireSphere((Vector2)transform.position  + bottomOffset, collisionRadius);
       
    }
}
