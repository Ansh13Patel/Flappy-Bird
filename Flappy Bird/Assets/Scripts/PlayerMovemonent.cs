using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemonent : MonoBehaviour
{
    private bool isdead = false;
    public float upforce = 200f;
    public Rigidbody2D rb;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AdsManger.Instance.ShowBannerAds();
        if (isdead == false)
        {
            if ( Input.touchCount>0)
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0,upforce));
                anim.SetInteger("State", 1);
            }
            if (Input.touchCount<1)
            {
                anim.SetInteger("State", 0);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            rb.velocity = Vector2.zero;
            anim.SetInteger("State", 3);
            isdead = true;
            GameController.instance.birddie();
        }
    }
}
