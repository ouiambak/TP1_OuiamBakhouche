using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRight : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    // Start is called before the first frame update
    public void InitializeVelocity()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.left * _speed;
    }
}
