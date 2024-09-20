using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _acceleration = 1f;
    [SerializeField] private float _angle = 30f;
    [SerializeField] private float _MaxSpeed = 3f;
    private Vector2 _position;
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
     
       
    }

    // Update is called once per frame
    void Update()
    {   
        // Avancer vers l'avant quand on appuie sur W
        if (Input.GetKey(KeyCode.W))
        {
            _speed += _acceleration * Time.deltaTime;
            if (_speed >= _MaxSpeed) { 
                _speed = _MaxSpeed;
            }
            transform.position += transform.up * _speed * Time.deltaTime;
        }

        // S'arrêter quand on appuie sur S
        if (Input.GetKey(KeyCode.S))
        {
            _speed -= _acceleration * Time.deltaTime;
            if (_speed <=0)
            {
                _speed = 0;
            }
        }

        // Tourner dans le sens anti-horaire quand on appuie sur A
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, _angle * Time.deltaTime);
        }

        // Tourner dans le sens horaire quand on appuie sur D
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -_angle * Time.deltaTime);
        }
    }
}
