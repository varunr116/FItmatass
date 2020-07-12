using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{
    
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            collision.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Debug.Log("Winner");

        }
    }
}
