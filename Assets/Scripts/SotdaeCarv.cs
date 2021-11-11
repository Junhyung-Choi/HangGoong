using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SotdaeCarv : MonoBehaviour
{
    private float time = 0f;

    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "Haptic" && time >= 3.0f && collider.gameObject.transform.Find("Cube").gameObject.activeSelf == true)
        {
            collider.gameObject.transform.Find("Cube").gameObject.SetActive(false);
            collider.gameObject.tag = "Untagged";
        }
        time += Time.deltaTime;
        GiveHaptic.ActivateHaptic();
    }

    void OnTriggerExit(Collider collider)
    {
        time = 0f;
    }
}
