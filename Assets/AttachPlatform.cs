using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlatform : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter");
        if (collider.CompareTag("Player"))
        {
            collider.gameObject.transform.parent = transform;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        Debug.Log("OnTriggerExit");
        if (collider.CompareTag("Player"))
        {
            collider.gameObject.transform.parent = null;
        }
    }

}