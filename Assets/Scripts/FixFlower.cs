using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixFlower : MonoBehaviour
{
    public AudioClip flower;
    AudioClip tmp;
    float time = 0f;

    void OnTriggerStay(Collider collider)
    {
        if(time > 0.1f && collider.gameObject.tag == "Attach")
        {
            tmp = GetComponent<AudioSource>().clip;
            GetComponent<AudioSource>().clip = flower;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().clip = tmp;
            AttachChild(collider.gameObject);
        }
        time += Time.deltaTime;
    }

    void OnTriggerExit(Collider collider)
    {
        time = 0f;
    }

    void AttachChild(GameObject child)
    {
        // GameObject origin = child.transform.parent.gameObject;
        GameObject origin = child;
        GameObject new_child = Instantiate(origin, origin.transform.position,Quaternion.Euler(origin.transform.localRotation.x,origin.transform.localRotation.y,origin.transform.localRotation.z));
        new_child.transform.parent = this.gameObject.transform;
        new_child.GetComponent<OffsetGrab>().enabled = false;
        new_child.GetComponent<BoxCollider>().enabled = false;
        new_child.transform.Find("AttachToVase").GetComponent<BoxCollider>().enabled = false;
        origin.SetActive(false);
    }
}
