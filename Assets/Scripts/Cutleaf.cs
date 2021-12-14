using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutleaf : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if(other.gameObject.tag == "Cuttable")
        {
            GetComponent<AudioSource>().Play();
            other.transform.parent = GameObject.Find("fallen_leaves").transform;
            other.gameObject.AddComponent<Rigidbody>();
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
