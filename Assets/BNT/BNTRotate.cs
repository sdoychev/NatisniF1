using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BNTRotate : MonoBehaviour
{
    public float rotationSpeed;
    
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);   
    }
}
