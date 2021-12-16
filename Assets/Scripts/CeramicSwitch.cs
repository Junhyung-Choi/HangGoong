using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeramicSwitch : MonoBehaviour
{
    public Mesh clay_piece;
    public Mesh brush_piece;
    public Material clay_material;
    public Material brush_material;

    private float time = 0f;
    private bool isChanged = false;
    private int index = 0;
    private string[] ceramic_list = {"11","22","33","44","55","66","77"};

    private ParticleSystem particleObject;
    private ParticleSystemRenderer render;

    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "Haptic" && time >= 0.3f && !isChanged)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            int before = index;
            index += 1;
            if (index == 8)
            {
                index = 1;
            }
            this.gameObject.transform.GetChild(before).gameObject.SetActive(false);
            this.gameObject.transform.GetChild(index).gameObject.SetActive(true);
            GiveHaptic.ActivateHaptic();
            isChanged = true;
            particleObject.Stop();
        } else if (collider.gameObject.tag == "Brush" && time >= 0.3f && !isChanged)
        {
            ChangeCeramicMaterial.changeAllColors(transform.GetChild(index).gameObject);
            GiveHaptic.ActivateHaptic();
            isChanged = true;
            particleObject.Stop();
        }
        time += Time.deltaTime;
        if((collider.gameObject.tag == "Haptic" || collider.gameObject.tag == "Brush" )&& time < 0.3f) 
        {
            if(collider.gameObject.tag=="Haptic")
            {
                var sh = particleObject.shape;
                sh.mesh = clay_piece;
                render.material = clay_material;
            }
            else
            {
                var sh = particleObject.shape;
                sh.mesh = brush_piece;
                render.material = brush_material;
            }
            particleObject.Play();
            GiveHaptic.ActivateHaptic();
        } 
    }

    void OnTriggerEnter(Collider collider)
    {
        time = 0f;
        isChanged = false;
    }

    void OnTriggerExit(Collider Collider)
    {
        particleObject.Stop();
    }

    void Start()
    {
        particleObject = GetComponent<ParticleSystem>();
        render = GetComponent<ParticleSystemRenderer>();
        particleObject.Stop();
    }

}
