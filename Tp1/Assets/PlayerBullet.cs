using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] GameObject Balle;
    [SerializeField] private TextMeshProUGUI _text;
    private int died = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {   EnemyShip vaisseau = collision.GetComponent<EnemyShip>();

        if (vaisseau != null)
        {
            Debug.Log("Collision détectée ");
            Destroy(vaisseau.gameObject);
            died++;
            Destroy(this.gameObject);
        }
    }
    public void DiedShip()
    {
        _text.text = died.ToString();
    }
}
