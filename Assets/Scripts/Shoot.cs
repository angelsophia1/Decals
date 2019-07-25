using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject effectPrefab;
    public GameObject decalPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }
    void Fire()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray,out hitInfo,100f))
        {
            //Instantiate(effectPrefab,hitInfo.point,Quaternion.LookRotation(hitInfo.normal));

            Instantiate(decalPrefab,hitInfo.point,Quaternion.FromToRotation(Vector3.up,hitInfo.normal));
        }
    }
}
