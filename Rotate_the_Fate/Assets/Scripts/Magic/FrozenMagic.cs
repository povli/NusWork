using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrozenMagic : MonoBehaviour
{
    public int damage = 1; 
    private static MagicSystem sMagicSystem = null;
    public static void InitializedMagicSystem(MagicSystem m) { sMagicSystem = m; }

    private const float kLifeTime = 0.75f; // Alife for this number of cycles
    private float mLifeCount = 0f; 
    // Start is called before the first frame update
    void Start()
    {
        mLifeCount = kLifeTime; 
    }

    // Update is called once per frame
    void Update()
    {
       DestroyThisMagic();
    }

    private void DestroyThisMagic()
    {
        mLifeCount -= Time.deltaTime;
        if(mLifeCount <= 0) 
        {
            Destroy(transform.gameObject);  // kills self
        }
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<Hit>().TakeFrozenDamage(damage, transform.position);
        }
    }
}
