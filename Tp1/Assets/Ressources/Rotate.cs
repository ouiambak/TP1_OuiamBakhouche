using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Rotate : MonoBehaviour
{   [SerializeField] private float _angle = 50f;
    [SerializeField] private float _speed = 3f;
    private float _orientation;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        RotateObject();

    }
    void RotateObject()
    {
        _orientation = transform.eulerAngles.z;
        if (_orientation >= -100 && _orientation <= 50)
        {   // Appliquer la rotation
            transform.Rotate(0, 0, _angle * Time.deltaTime*_speed); 
        }

            // Si l'angle dépasse -50 degrés
        if (_orientation < -100)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z+_angle);
        }

            // Si l'angle dépasse 50 degrés
        if (_orientation > 50)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - _angle);
        }
    }
}
