using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixFlower : MonoBehaviour
{
    public AudioClip flower;
    AudioClip tmp;
    float time = 0f;

    private bool isAttached = false;

    void OnTriggerStay(Collider collider)
    {
        if(!isAttached && time > 0.1f && collider.gameObject.tag == "Flower")
        {
            tmp = GetComponent<AudioSource>().clip;
            GetComponent<AudioSource>().clip = flower;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().clip = tmp;
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
        GameObject origin = child.transform.parent.gameObject;
        GameObject prefab = GameObject.Find("Flowers").transform.Find(origin.name).gameObject;
        GameObject new_child = new GameObject();
        GameObject par = new GameObject("par");
        // GameObject origin = child;
        if(origin.name.StartsWith("Tul"))
        {
            new_child = Instantiate(prefab, origin.transform.position, origin.transform.rotation);
        }
        else
        {
            new_child = Instantiate(prefab, origin.transform.position, origin.transform.rotation);
        }

        // new_child = Instantiate(prefab, origin.transform.position, origin.transform.rotation);
        new_child.transform.parent = par.transform;
        new_child.transform.localPosition = Vector3.zero;
        par.transform.position = origin.transform.position;
        par.transform.parent =  this.gameObject.transform;
        // new_child.GetComponent<OffsetGrab>().enabled = false;
        // new_child.GetComponent<BoxCollider>().enabled = false;
        // new_child.transform.Find("AttachToVase").GetComponent<BoxCollider>().enabled = false;
        // new_child.transform.Find("AttachToVase").gameObject.SetActive(false);
        origin.SetActive(false);
    }
}
