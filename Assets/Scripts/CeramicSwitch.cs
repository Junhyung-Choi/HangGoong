using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeramicSwitch : MonoBehaviour
{
    public GameObject clay_piece;
    private float time = 0f;
    private bool isChanged = false;
    private int index = 0;
    private string[] ceramic_list = {"11","22","33","44"};

    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "Haptic" && time >= 3.0f && !isChanged)
        {
            int before = index;
            index += 1;
            if (index == 5)
            {
                index = 1;
            }
            this.gameObject.transform.GetChild(before).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(index).gameObject.SetActive(true);
            GiveHaptic.ActivateHaptic();
            isChanged = true;
        }
        time += Time.deltaTime;
    }

    void OnTriggerEnter(Collider collider)
    {
        time = 0f;
        isChanged = false;
    }

    private void OnTriggerExit(Collider other) {
        isChanged = false;    
    }
}
