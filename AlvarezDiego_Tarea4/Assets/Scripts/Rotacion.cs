using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
   
    public float velocidadx = 0;
    public float velocidadz = 0;
    public float amplitud = 0;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
 
        transform.localPosition = startPos + new Vector3(Mathf.Sin(Time.time * velocidadx) * amplitud, 0, Mathf.Sin(Time.time * velocidadz) * amplitud);
    }
}
