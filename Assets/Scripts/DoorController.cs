using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour 
{
    public Door door;

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
            door.Open();
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.CompareTag("Player"))
            door.Close();
    }
}
