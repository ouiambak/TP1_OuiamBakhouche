using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class escapes : MonoBehaviour
{
    // Texte pour afficher le compteur de vaisseaux
    [SerializeField] private TextMeshProUGUI shipCountText;

    // Compteur de vaisseaux
    private int shipCount = 0;

    // Lorsque un vaisseau entre dans la zone (avec un Collider 2D ou 3D Trigger)
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si l'objet qui entre a le tag "Ship"
        if (other.gameObject.CompareTag("Vaisseaux"))
        {
            // Incrémente le compteur de vaisseaux
            shipCount++;

            // Met à jour le texte affichant le nombre de vaisseaux
            UpdateShipCountText();
        }
    }

    // Met à jour le texte pour afficher le nombre de vaisseaux
    private void UpdateShipCountText()
    {
        shipCountText.text =shipCount.ToString();
    }
}

