using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachSotdaeonBoard : MonoBehaviour
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
        isAttached = false;
    }

    void AttachChild(GameObject child)
    {
        // GameObject origin = child.transform.parent.gameObject;
        GameObject origin = child;
        GameObject new_child = Instantiate(origin, origin.transform.position, origin.transform.rotation);
        GameObject par = new GameObject("par");
        new_child.transform.parent = par.transform;
        new_child.tag = "Untagged";
        par.transform.position = origin.transform.position;
        par.transform.parent = this.transform;
        new_child.transform.localPosition = Vector3.zero;
        // new_child.GetComponent<OffsetGrab>().enabled = false;
        child.SetActive(false);
    }
}
