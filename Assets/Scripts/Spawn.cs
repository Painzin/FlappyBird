using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obs;
    public GameObject chao;
    public float dificuldade;
    private Vector3 hehe;
    private Vector3 chaohehe;

    // Update is called once per frame
    void Update()
    {
        dificuldade = dificuldade + Time.deltaTime;
        spawna();
    }
    
    void spawna() 
    {

        if (dificuldade >= 1.5) {
            hehe = new Vector3(28f, Random.Range(4.5f, -4.5f), 0f);
            Instantiate( obs, hehe, new Quaternion(0f, 0f, 0f, 0f));
            chaohehe = new Vector3(-1f, 3.5f, 0f);
            Instantiate( chao, chaohehe, new Quaternion(0f, 0f, 0f, 0f));
            dificuldade = 0f;
        }
    }
}
