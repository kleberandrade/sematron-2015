using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour 
{
    public float force = 1000.0f;
    public Rigidbody bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody go = (Rigidbody)Instantiate(bulletPrefab,
                transform.position, transform.rotation);

            go.AddForce(transform.forward * force);
        }
    }
}
