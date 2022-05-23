using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopControl : MonoBehaviour
{
    private Rigidbody rg;
    public float Hiz = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(dikey, 0, -yatay);
        rg.AddForce(kuvvet*Hiz);

    }
}
