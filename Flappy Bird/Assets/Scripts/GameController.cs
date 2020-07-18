using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameovertext;
    public bool gameover = false;
    private int score = 0;
    public Text Scoretext;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }
    public void Playerscore()
    {
        if (gameover == true)
        {
            return;
        }
          score++;
          Scoretext.text = score.ToString();
        
    }
    public void birddie()
    {
        gameovertext.SetActive (true);
        gameover = true;
    }
}
