using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] GameObject Balle;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {   EnemyShip vaisseau = collision.GetComponent<EnemyShip>();

        if (vaisseau != null)
        {
            Debug.Log("Collision détectée ");
            Destroy(vaisseau.gameObject);
          
            Destroy(this.gameObject);
           
        }
    }
    
}
