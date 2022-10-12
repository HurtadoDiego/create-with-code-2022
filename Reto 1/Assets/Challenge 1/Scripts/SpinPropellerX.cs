using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float spin=1000f;
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * spin);
    }
}
