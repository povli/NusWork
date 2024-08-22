using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSystem 
{
    public static float kYDistance = 1.5f;
    public static float kXDistance = 0.5f;
    private GameObject mFrozenSample = null;
    private GameObject mLightningXSample = null;
    private GameObject mFlameSample = null;
    public MagicSystem()
    {
        FrozenMagic.InitializedMagicSystem(this);
        mFrozenSample = Resources.Load<GameObject>("Prefabs/Frozen") as GameObject;
        // mLightningXSample = Resources.Load<GameObject>("Prefabs/LightningX") as GameObject;
        // mFlameSample = Resources.Load<GameObject>("Prefabs/FlameThrow") as GameObject;
    }

    public void FrozenSpawner(Vector3 p, bool torwardRight)
    {
        GameObject frozen = GameObject.Instantiate(mFrozenSample) as GameObject;

        if(torwardRight)
        {
            frozen.transform.position = p + Vector3.right*kYDistance + Vector3.up*kXDistance;
            frozen.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            frozen.transform.position = p + Vector3.left*kYDistance + Vector3.up*kXDistance;
            frozen.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
            
    }

    public void FlashXSpawner(Vector3 p, bool torwardRight)
    {
        // GameObject l = GameObject.Instantiate(mLightningXSample) as GameObject;

        // if(torwardRight)
        // {
        //     l.transform.position = p + Vector3.right*kYDistance;
        //     l.transform.localRotation = Quaternion.Euler(0, 0, 0);
        // }
        // else
        // {
        //     l.transform.position = p + Vector3.left*kYDistance;
        //     l.transform.localRotation = Quaternion.Euler(0, 180, 0);
        // }
            
    }

    public void FlameSpawner(Vector3 p, bool torwardRight)
    {
        // GameObject flame = GameObject.Instantiate(mFlameSample) as GameObject;

        // if(torwardRight)
        // {
        //     flame.transform.position = p + Vector3.right;
        //     flame.transform.localRotation = Quaternion.Euler(0, 0, 0);
        // }
        // else
        // {
        //     flame.transform.position = p + Vector3.left;
        //     flame.transform.localRotation = Quaternion.Euler(0, 180, 0);
        // }
            
    }
}
