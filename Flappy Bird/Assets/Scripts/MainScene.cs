using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0)
        {
            Invoke("loadscene", 1.0f);
        }
        
    }
    void loadscene()
    {
        SceneManager.LoadScene(1);
    }
}
