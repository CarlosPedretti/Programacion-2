using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private float velocidadPiso = 8f;
    void Start()
    {
        
    }

    void Update()
    {
      transform.Translate(Vector3.left * velocidadPiso * Time.deltaTime);
    }
}
