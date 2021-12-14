using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDuck : MonoBehaviour
{
    public GameObject Cube;

    public Vector3 spawn_point;

    public void addDuck()
    {
        Instantiate(Cube,spawn_point, Quaternion.Euler(0,0,0));
    }
}
