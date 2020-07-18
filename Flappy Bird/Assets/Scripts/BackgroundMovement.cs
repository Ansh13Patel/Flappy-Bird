using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D box2d;
    private float horizontallength;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1f, 0);
        box2d = GetComponent<BoxCollider2D>();
        horizontallength = box2d.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(GameController.instance.speed, 0);
        if (GameController.instance.gameover == true)
        {
            rb.velocity = Vector2.zero;
        }
        if (transform.position.x < -horizontallength)
        {
            Repeating();
        }
       
    }
    void Repeating()
    {
        Vector2 offset = new Vector2(horizontallength*2f, 0);
        transform.position = (Vector2)transform.position + offset;

    }
}
