using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class boom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject fire;
    [SerializeField] private TextMeshProUGUI vie;
    [SerializeField] private GameOver frame;
    private int died = 10;
    private float _timer = 0;
    private bool _fadeIn = false;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _fadeDelay = 3f;

    // Appel� lorsque le vaisseau entre en collision avec un objet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision d�tect�eeeeeeeeee");

        // Si la collision est avec un objet tagu� "fire"
        if (collision.gameObject.CompareTag("fire"))
        {
            Debug.Log("fadinngggg");
            _fadeIn = true; // D�clenche le fade
            died--; // desincr�mente le compteur de d�c�s
            fading();
            DiedShip(); // Met � jour l'affichage de la vie

            if (died == 0)
            {
                overGame();
            }
            
        }
    }

    // Appel� � chaque frame
    private void Update()
    {
      
        
    }
    private void fading() {
        // Si le fade a �t� activ�
        if (_fadeIn)
        {
            // Incr�mente le timer
            _timer += Time.deltaTime;

            // Calcul du pourcentage de fade-out (on veut que l'alpha diminue de 1 � 0)
            float alpha = Mathf.Clamp( (_timer / _fadeDelay), 0f, 1f);

            // Applique la nouvelle transparence � l'objet (fade-out)
            _spriteRenderer.color = new Color(1f, 1f, 1f, alpha);

            // Si le fade est termin� (alpha est proche de 0)
            if (alpha <= 0f)
            {
                Destroy(this.gameObject); // D�truit l'objet une fois le fade-out termin�
            }
        }
    }
    // Met � jour le texte de l'UI pour refl�ter le nombre de morts
    public void DiedShip()
    {
        vie.text = died.ToString();
    }
    public void overGame()
    {
        
            frame.SetUp();
        
    }
}
