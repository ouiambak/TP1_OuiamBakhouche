using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _fadeDelay = 10f;
    private float _timer;
    private bool _fadeIn;

    public void FadeIn()
    {
        _fadeIn = true;
        _timer = 0;
    }
    public void FadeOut()
    {
        _fadeIn = false;
        _timer = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer.color = new Color(1f,1f,1f,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_fadeIn == true) {
            _spriteRenderer.color = new Color(1f, 1f, 1f, _timer / _fadeDelay);
        }
        else
        {
            _spriteRenderer.color = new Color(1f,1f,1f,1-_timer / _fadeDelay);
        }
    }
}
