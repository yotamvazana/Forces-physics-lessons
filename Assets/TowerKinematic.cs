using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerKinematic : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform deployBullet;
    [SerializeField] private float forcePower;
    [SerializeField] private float hight;
    [SerializeField] private Transform towerHight;

    void Start()
    {
        hight = towerHight.position.y;

    }

    void Update()
    {
        towerHight.position = new Vector3(towerHight.position.x, hight, towerHight.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            InstantiateObject();
        }
    }

    void InstantiateObject()
    {
        //Vector3 rotation = new Vector3(Mathf.Cos(transform.eulerAngles.z),Mathf.Sin(transform.eulerAngles.z), 0) * Mathf.Rad2Deg;

        var projectile = Instantiate(bullet, deployBullet.position, Quaternion.identity);
        projectile.GetComponent<BulletKinematic>().Init(transform.rotation * Vector3.right * forcePower);
        Debug.Log(transform.rotation * Vector3.right * forcePower);
    }
}
