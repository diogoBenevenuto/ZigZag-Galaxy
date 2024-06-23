using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaController : MonoBehaviour
{

    [SerializeField]
    private float vel = 1f, limiteVel = 2.5f;
    [SerializeField]
    private Rigidbody rb;
    public static bool gameOver = false;
    [SerializeField]
    private int moedasNum = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(vel, 0, 0);

        StartCoroutine (AjustaVel());
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            MovBola();
        }

       if(!Physics.Raycast(transform.position, Vector3.down, 1))
        {
            gameOver = true;
            rb.useGravity = true;
        }

       if(gameOver)
        {
            print("Caindo!");
        }

     }

    void MovBola()
    {
        if(rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, vel);
        }
        else if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(vel, 0, 0);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("moeda"))
        {
            Destroy(col.gameObject);
            moedasNum++;

        }

        
    }

    IEnumerator AjustaVel()
    {
        while(!gameOver)
        {
            yield return new WaitForSeconds(2);
            if(vel <= limiteVel)
            {
                vel += 0.2f;
            }
            
        }
    }
}
