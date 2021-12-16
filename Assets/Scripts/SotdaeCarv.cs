using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SotdaeCarv : MonoBehaviour
{
    public GameObject wood_piece;
    private ParticleSystem praticleObject;
    private float time = 0f;

    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "Haptic" && time >= 3.0f && collider.gameObject.transform.Find("Cube").gameObject.activeSelf == true)
        {
            collider.gameObject.transform.Find("Cube").gameObject.SetActive(false);
            collider.gameObject.tag = "Attach";
            GiveHaptic.ActivateHaptic();
            // this.GetComponent<OffsetGrab>().enabled = true;
            praticleObject.Stop();
        }
        time += Time.deltaTime;
        praticleObject.Play();
    }

    void OnTriggerEnter(Collider collider)
    {
        time = 0f;
        praticleObject.Stop();
    }

    void OnTriggerExit(Collider collider)
    {
        time = 0f;
        praticleObject.Stop();
    }

    void Start()
    {
        praticleObject = GetComponent<ParticleSystem>();
        praticleObject.Stop();
    }
}
