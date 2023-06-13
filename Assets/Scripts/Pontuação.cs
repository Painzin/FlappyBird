using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pontuação : MonoBehaviour
{
    public static int pontos = 0;
    public TextMeshProUGUI Show1;
    public TextMeshProUGUI Show;

    void Update() 
    {
        transform.Translate(Vector2.left * 7f * Time.deltaTime);
        reinic();
    }

    void reinic() 
    {
        if (Playbut.reinicio == true) 
        {
            transform.position = new Vector2(29, 0);
            pontos = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D otherCollider) 
    {
        pontos = pontos + 1;
        Show.text = pontos.ToString();
        Show1.text = pontos.ToString();
        transform.position = transform.position + new Vector3(10.503f, 0f, 0f);
    }
}
