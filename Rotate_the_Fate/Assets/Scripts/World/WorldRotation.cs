using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldRotation : MonoBehaviour
{
    public static bool isRotating = false;    
    public float rotationSpeed = 20f; 
    private Quaternion targetRotation; // 目标旋转角度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Rotation();
    }

    void Rotation() 
    {
         if (Input.GetKeyDown(KeyCode.N) && !isRotating)
        {
            isRotating = true;
            targetRotation = Quaternion.Euler(0, 0, 90) * transform.rotation;
        }
            
        if (Input.GetKeyDown(KeyCode.M) && !isRotating)
        {
            isRotating = true;
            targetRotation = Quaternion.Euler(0, 0, -90) * transform.rotation;
        }

        if (isRotating)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
            {
                transform.rotation = targetRotation;
                isRotating = false;
            }
            
        }
    }
}
