using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCraft : MonoBehaviour
{
    float time = 0f;
    bool isAttached = false;

    void OnTriggerStay(Collider collider)
    {
        if(!isAttached && time > 0.1f && collider.gameObject.tag == "Attach")
        {
            GetComponent<AudioSource>().Play();
            AttachChild(collider.gameObject);
            isAttached = true;
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
        GameObject new_child = Instantiate(origin, origin.transform.position,Quaternion.Euler(0,origin.transform.localRotation.y,0));
        new_child.transform.parent = this.gameObject.transform;
        new_child.GetComponent<OffsetGrab>().enabled = false;
        origin.SetActive(false);
    }
}
