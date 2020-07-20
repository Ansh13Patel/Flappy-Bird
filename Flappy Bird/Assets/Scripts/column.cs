using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class column : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource pointaudio;
    
   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1f, 0);
        pointaudio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (GameController.instance.gameover == true)
        {
            rb.velocity = Vector2.zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pointaudio.Play();
            GameController.instance.Playerscore();
        }
    }
}
