using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] GameObject Balle;
    [SerializeField] GameObject vaisseau;
    [SerializeField] private TextMeshProUGUI _text;
    private int died = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {   EnemyShip ship = collision.GetComponent<EnemyShip>();

        if (ship != null)
        {
            Debug.Log("Collision détectée ");
            Destroy(ship.gameObject);
            died++;
            Destroy(this.gameObject);
        }
    }
    public void DiedShip()
    {
        _text.text = died.ToString();
    }
}
