using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameovertext;
    public bool gameover = false;
    private int score = 0;
    public Text Scoretext;
    public AudioSource dieaudio;
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
        Scoretext.text = "Score:- " + score.ToString();

    }
    public void birddie()
    {
        dieaudio = GetComponent<AudioSource>();
        dieaudio.Play();
        gameovertext.SetActive(true);
        gameover = true;
        AdsManger.Instance.ShowInterstitialAds();
    }
  
}
