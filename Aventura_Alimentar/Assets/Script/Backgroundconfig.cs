using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundconfig : MonoBehaviour
{
    public MeshRenderer mr;
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
