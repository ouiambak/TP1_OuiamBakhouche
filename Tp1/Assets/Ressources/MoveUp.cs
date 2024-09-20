using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    [SerializeField] private float _speed = 8.0f;
    // Start is called before the first frame update
    public void InitializeVelocity()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * _speed;
    }
}
