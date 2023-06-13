using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float speed = 7f;
    public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        Destroy(obj, 8);
        if ( Playbut.reinicio == true) 
        {
            Destroy(obj);
        }
    }

}
