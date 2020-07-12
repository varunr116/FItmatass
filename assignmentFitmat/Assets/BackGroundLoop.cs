using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundLoop : MonoBehaviour
{
    public GameObject bg;
    Camera cm;
    Vector2 screen_bound;
    private void Start()
    {
        cm = gameObject.GetComponent<Camera>();
        screen_bound=cm. ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, transform.position.z));
        Show_bg(bg);
    }
    void Show_bg(GameObject obj)
    {
        float width = bg.GetComponent<SpriteRenderer>().bounds.size.x;
        GameObject gm = Instantiate(bg) as GameObject;
    }

}
