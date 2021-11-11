using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GiveHaptic : MonoBehaviour
{
    private XRController xr;
    // Start is called before the first frame update
    void Start()
    {
        xr = this.GetComponent<XRController>();
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("IsTriggerEnter");
        if(collider.gameObject.tag == "Haptic")
        {
            ActivateHaptic();
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "Haptic")
        {
            ActivateHaptic();
        }
    }

    // Update is called once per frame
    void ActivateHaptic()
    {
        xr.SendHapticImpulse(0.3f, 0.1f);
    }
}
