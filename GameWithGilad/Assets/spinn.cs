using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class spinn : MonoBehaviour
{
    public float RotationSpeed = 150f;
    public GameObject lol;

    void Update()
    {
        lol.Transform.Rotate(Vector3.up, RotationSpeed * Time.deltaTime);
    }
}