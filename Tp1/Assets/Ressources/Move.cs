using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _angle = 20;
    private Vector2 _position;
    // Start is called before the first frame update
    void Start()
    {
     
       
    }

    // Update is called once per frame
    void Update()
    {   
        // Avancer vers l'avant (vers la droite dans Unity 2D) quand on appuie sur W
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * _speed * Time.deltaTime;
        }

        // S'arrêter quand on appuie sur S
        if (Input.GetKey(KeyCode.S))
        {
            // Le vaisseau ne bouge plus, donc on ne change rien à la position.
            // Cette ligne peut être laissée vide si tu veux juste arrêter le mouvement.
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
