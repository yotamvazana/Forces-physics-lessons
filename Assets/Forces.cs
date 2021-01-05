using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Forces : MonoBehaviour
{
    [SerializeField] Text velocityText;

    private List<Vector3> forces;
    private Vector3 shakul;
    [SerializeField] private Vector3 gravity = new Vector3(0,-9.81f,0);

    private float gravityCounter = 0;

    private Rigidbody rb;
    
    void Start()
    {
        forces = new List<Vector3>();

        forces.Add (new Vector3(1f, 0 , 2f));
        forces.Add(new Vector3(0,7f,2f));

        rb = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        gravityCounter += Time.fixedDeltaTime;

        shakul = Vector3.zero;
        for (int i = 0; i < forces.Count; i++)
        {
            shakul += forces[i];
        }

        shakul += gravityCounter * gravity;

        rb.position = transform.position + shakul;

        //transform.Translate(shakul);

        // Vector3 pos = transform.position;
        //do changes
        // pos += shakul;
        //transform.position = pos;
    }
}
