using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenContact : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Boundary")
            return;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
