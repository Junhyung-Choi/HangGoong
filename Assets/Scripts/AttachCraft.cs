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
            Debug.Log("Shit");
            GetComponent<AudioSource>().Play();
            AttachChild(collider.gameObject);
            isAttached = true;
        }
        time += Time.deltaTime;
    }

    void OnTriggerExit(Collider collider)
    {
        Debug.Log("hi");
        time = 0f;
    }

    void AttachChild(GameObject child)
    {
        // GameObject origin = child.transform.parent.gameObject;
        GameObject origin = child;
        GameObject prefab = GameObject.Find("Ceramics").transform.Find(origin.name).gameObject;
        GameObject new_child = Instantiate(prefab, new Vector3(0,origin.transform.position.y,0), Quaternion.Euler(0,0,0));
        new_child.transform.parent = transform;
        new_child.transform.localPosition = new Vector3(0,origin.transform.position.y,0);
        // new_child.GetComponent<OffsetGrab>().enabled = false;
        child.SetActive(false);
    }
}
