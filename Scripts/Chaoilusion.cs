using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaoilusion : MonoBehaviour
{
    public float VRUM = 7f;
    public GameObject chaozin;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * VRUM * Time.deltaTime);
        Destroy(chaozin, 10);
    }
}
