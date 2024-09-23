using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Rotate : MonoBehaviour
{   [SerializeField] private float _MAXangle = 50f;
    [SerializeField] private float _offset = 120f;
    [SerializeField] private float _speed = 10f;
    private float _orientation;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        RotateObject();

    }
    void RotateObject()
    {
        float angleZ = Mathf.PingPong(Time.time * _speed, _MAXangle * 2) - _MAXangle+_offset;
        transform.eulerAngles = new Vector3(0, 0, angleZ);
    }
}
