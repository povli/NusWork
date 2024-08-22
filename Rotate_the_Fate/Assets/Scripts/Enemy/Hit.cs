using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int mFrozenCount = 0;
    private SpriteRenderer spriteRenderer;
    private GameObject mIceBlockSample = null;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        mIceBlockSample = Resources.Load<GameObject>("Prefabs/FrozenEffect") as GameObject;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void TakeFrozenDamage(int damage, Vector2 attP) {
        if(mFrozenCount == 0) {

            if(attP.x < transform.position.x) {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 1) * 5, ForceMode2D.Impulse);
            } else {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 1) * 5, ForceMode2D.Impulse);
            }
            spriteRenderer.color = new Color(0.078f, 0.761f, 1.0f); // RGB values for #14C2FF

            mFrozenCount++;
        }else if(mFrozenCount == 1) {
            GameObject iceBlock = GameObject.Instantiate(mIceBlockSample) as GameObject;
            iceBlock.transform.localPosition = transform.position;
            iceBlock.transform.parent = transform;
            anim.speed = 0;
            mFrozenCount++;
        }
    }
}
