using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public List<MagicType> currentMagic;
    public int chooseMagic = 0;
    private MagicSystem mMagicSystem = null;
    // Start is called before the first frame update
    void Awake()
    {
        mMagicSystem = new MagicSystem();
    }
    void Start()
    {
        currentMagic.Add(MagicType.Frozen);
        currentMagic.Add(MagicType.FlashX);
        currentMagic.Add(MagicType.Flame);
    }

    // Update is called once per frame
    void Update()
    {
        MagicAttack();
        SwitchMagic();
    }

    public void MagicAttack() {
        if(Input.GetKeyDown(KeyCode.J))
        {
            switch(currentMagic[chooseMagic])
            {
                case MagicType.Frozen:
                    mMagicSystem.FrozenSpawner(transform.position, GetComponent<CupidBehavior>().mTowardRight);
                    break;
                case MagicType.FlashX:
                    mMagicSystem.FlashXSpawner(transform.position, GetComponent<CupidBehavior>().mTowardRight);
                    break;
                case MagicType.Flame:
                    mMagicSystem.FlameSpawner(transform.position, GetComponent<CupidBehavior>().mTowardRight);
                    break;
            }
        }
    }

    public void SwitchMagic() {
        if(Input.GetKeyDown(KeyCode.H))
        {
            chooseMagic++;
            chooseMagic = chooseMagic%currentMagic.Count;
        }
       
    }

}
