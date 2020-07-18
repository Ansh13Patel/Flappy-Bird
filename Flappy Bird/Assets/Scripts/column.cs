using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class column : MonoBehaviour
{
    public Rigidbody2D rb;
    
   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1f, 0);
    }
     void OnTiggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<PlayerMovemonent> () != null)
        {
            GameController.instance.Playerscore();
        }
    }
}
