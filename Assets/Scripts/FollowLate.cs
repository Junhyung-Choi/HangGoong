using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowLate : MonoBehaviour
{
    public GameObject target;
    public float DelayTime;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * DelayTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.transform.rotation, Time.deltaTime * DelayTime);
    }
}