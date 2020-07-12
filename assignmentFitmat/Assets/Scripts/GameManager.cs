using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject player,rope;
    Rigidbody2D rb;
    BoxCollider2D box_collider;
    public float force;
    private void Start()
    {
     rb =player. GetComponent<Rigidbody2D>();
        box_collider =player. GetComponent<BoxCollider2D>();


    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // OnButtonPress();
        }
      
    }
   public void OnButtonPress()
    {
        On_Deattach();
    }
   internal protected void DisableGravity(Transform trans)
    {
     
        // player.transform.localRotation = Quaternion.Euler(0, 0, 0);
        player.transform.parent = trans.transform;
        box_collider.isTrigger = true;
        player.transform.localRotation = Quaternion.Euler(0, 0, -90);
        player.transform.localPosition = new Vector3(-4.5f, 0, 0);
        rb.mass = 0;
        rb.velocity = new Vector2(0, 0);
        rb.bodyType = RigidbodyType2D.Kinematic;
       




    }
 public   void On_Deattach()
    {
        player.transform.parent = null;
        rb.mass = 1;
        box_collider.isTrigger = false;
        rb.bodyType = RigidbodyType2D.Dynamic;
       // rb.drag = 1;

        //  box_collider.isTrigger = false;
        rb.AddForce(player.transform.right * force);


    }
}
