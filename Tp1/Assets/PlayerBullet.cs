using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] GameObject Balle;
    [SerializeField] GameObject vaisseau;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {   EnemyShip ship = collision.GetComponent<EnemyShip>();

        if (ship != null)
        {
            Debug.Log("Collision d�tect�e ");
            Destroy(ship.gameObject);
            Destroy(this.gameObject);
        }
    }
}
