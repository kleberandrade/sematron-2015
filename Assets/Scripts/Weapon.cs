using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour 
{
    public float force = 10.0f;
    public Rigidbody bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody go = (Rigidbody) Instantiate(bulletPrefab);
            go.position = transform.position;
            go.rotation = transform.rotation;
            go.AddForce(transform.forward * force);
        }
    }
}
