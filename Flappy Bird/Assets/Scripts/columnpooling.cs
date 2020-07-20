using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnpooling : MonoBehaviour
{
    public GameObject colunmprefap;
    public int columnsize = 5;
    public float columnmin = -2.5f;
    public float columnmax = 3f;
    public float spawnrate = 5f;

    private GameObject[] columns;
    private Vector2 offscreen = new Vector2(-20f, -20f);
    private float positionx = -8f;
    private float positiony;
    private float timetospawn=0f;
    private int currentcolumn = 0;

    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnsize];
        for(int i = 0; i < columnsize; i++)
        {
            columns[i] = (GameObject)Instantiate(colunmprefap, offscreen, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timetospawn += Time.deltaTime;
        if(GameController.instance.gameover==false && timetospawn >= spawnrate)
        {
            timetospawn = 0;
            positiony = Random.Range(columnmin, columnmax);
            columns[currentcolumn].transform.position = new Vector2(positionx, positiony);
            currentcolumn++;
            if (currentcolumn == columnsize)
            {
                currentcolumn = 0;
            }
        }

       

        
    }
}
