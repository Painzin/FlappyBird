using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerb;
    public float strengh = 3f;
    public float waitime = 0;
    public static bool perder;
    public bool startwait;
    private Vector2 jump;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        playerb = GetComponent<Rigidbody2D>();
        perder = false;
        jump = new Vector2(0f, 1f);
        playerb.velocity = Vector2.up * strengh;
    }

    void Update()
    {
        waitime = waitime + Time.deltaTime;
        reini();
        pulo();
    }

    void reini() 
    {
        if (Playbut.reinicio == true) 
        {
            transform.position = Vector2.zero;
            playerb.velocity = Vector2.zero;
        }
    }
    
    void pulo() 
    {
        if(Input.GetKeyDown("space")){
            jump = new Vector2(0f, 1f);
            playerb.velocity = Vector2.up * strengh;
            Timer();
        }
    }

    void Timer() 
    {
        waitime = 0f;
        if(waitime >= 0.2) {
            playerb.velocity = -Vector2.up * strengh;
            waitime = 0f;
        }
        
    }

        void OnCollisionEnter2D(Collision2D o) 
    {
        perder = true;
        Time.timeScale = 0f;
    }

}
