using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Cube") || hitInfo.collider.CompareTag("Cilindro"))
                {
                    rb = hitInfo.collider.GetComponent<Rigidbody>();
                    if (rb)
                        rb.AddForce(-hitInfo.normal * 10, ForceMode.Impulse);
                }

            }
        }
    }
    private void OnMouseOver()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
