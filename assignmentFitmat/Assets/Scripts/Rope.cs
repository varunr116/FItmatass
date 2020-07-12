using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{

    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    public float _leftside,_rightside,force;
    public float dir;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = dir*force;
        
    } 
    void Addforce()
    {
       // Debug.Log(transform.rotation.z);
        // Debug.Log("" + rb.angularVelocity);
        if ( transform.rotation.z >90 &&transform.rotation. z<_rightside&& rb.angularVelocity > 0 && rb.angularVelocity<force)
        {
           // Debug.Log(transform.rotation.z);
            Debug.Log("Reached");
           // rb.angularVelocity = dir * force;
           rb.angularVelocity = force*1;
        }
        else if (transform.rotation.z<90&& transform.rotation.z > _leftside && rb.angularVelocity < 0 && rb.angularVelocity > force)
        {
          //  rb.angularVelocity = dir * force;
            rb.angularVelocity = force*-1;
            Debug.Log("Reached 2");
        }
    }
 
    // Update is called once per frame
    void Update()
    {
       // rb.angularVelocity = dir * force;

        Addforce();
    }
}
