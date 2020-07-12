using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    internal protected bool player_support;
    public GameManager gm;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Rope"))
    //    {
    //        GameObject live_object = collision.transform.gameObject;
            
    //        gm.DisableGravity(live_object.transform);
    //        Debug.Log("Collied");
            
    //        //player_support = true;
    //    }
    //    else
    //    {
    //       // player_support = false;
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject. CompareTag("Rope"))
        {
            GameObject live_object = collision.transform.gameObject;

            gm.DisableGravity(live_object.transform);
            Debug.Log("Collied");

            //player_support = true;
        }
    }
}
