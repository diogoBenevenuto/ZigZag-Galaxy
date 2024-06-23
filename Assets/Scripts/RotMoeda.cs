using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotMoeda : MonoBehaviour
{

    [SerializeField]
    private float vel = 80;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, vel * Time.deltaTime));
    }
}
