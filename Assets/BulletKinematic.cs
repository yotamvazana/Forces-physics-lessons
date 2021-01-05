using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletKinematic : MonoBehaviour
{
    private List<Vector3> forceList;

    private Vector3 shakul;

    [SerializeField] private Vector3 gravity = new Vector3(0, -9.81f, 0);
    [SerializeField] private Rigidbody bullet;
    

    private float gravityCounter = 0;


    public void Init(Vector3 direction)
    {
        bullet = GetComponent<Rigidbody>();

        forceList = new List<Vector3>();

        forceList.Add(direction);
        Debug.Log(direction);
    }

    void FixedUpdate()
    {
        shakul = Vector3.zero;
        gravityCounter += Time.fixedDeltaTime;

        for (int i = 0; i < forceList.Count; i++)
        {
            shakul += forceList[i];
        }
        
        shakul += gravityCounter * gravity;

        bullet.position = transform.position + shakul;
    }
}
