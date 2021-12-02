using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GiveHaptic : MonoBehaviour
{
    public static XRController xr;
    public static XRBaseController xr2;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("IsCollisionEnter");
        if(collider.gameObject.tag == "Haptic")
        {
            ActivateHaptic();
        }
    }

    void OnTriggerStay(Collider collider)
    {
        Debug.Log("IsCollisionEnter");
        if(collider.gameObject.tag == "Haptic")
        {
            ActivateHaptic();
        }
    }

    // Update is called once per frame
    public static void ActivateHaptic()
    {
        xr = GameObject.Find("RightHand Controller").GetComponent<XRController>();
        xr.SendHapticImpulse(0.3f, 0.1f);
        GameObject check = GameObject.Find("LeftHand Controller"); 
        xr2 = GameObject.Find("LeftHand Controller").GetComponent<XRBaseController>();
        xr2.SendHapticImpulse(0.3f, 0.1f);
    }
}
