using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 pos = Vector3.zero;
    Vector3 angle = Vector3.zero;

    private void Awake()
    {
        pos = transform.position;
        angle = transform.eulerAngles;
    }

    public void StartPos()
    {
        transform.position = pos;
        transform.eulerAngles = angle;
    }
}
