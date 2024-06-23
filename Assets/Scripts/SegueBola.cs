using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueBola : MonoBehaviour
{
    [SerializeField]
    private Transform bola;
    [SerializeField]
    private Vector3 dist;
    [SerializeField]
    private float lerpVal;
    [SerializeField]
    private Vector3 pos,alvoPos;
   
    void Start()
    {
        dist = bola.position - transform.position;

    }

    void Update()
    {
        
    }

    void LateUpdate()
    {
        if(!BolaController.gameOver)
        {
            PersegueFunc();
        }
        
    }

    void PersegueFunc()
    {
        pos = transform.position;
        alvoPos = bola.position - dist;
        pos = Vector3.Lerp(pos, alvoPos, lerpVal);
        transform.position = pos;
    }
}
