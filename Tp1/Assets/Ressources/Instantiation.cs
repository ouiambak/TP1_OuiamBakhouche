using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Instantiation : MonoBehaviour
{
    [SerializeField] private GoRight _InstantiatePrefab;
    [SerializeField] private float _delay=2f;
    [SerializeField] private float _delayToDestroy = 6f;
    private float _timer;
    // Position maximum sur l'axe y
    public int _yMin = 2;     // Position minimum sur l'axe Y
    public int _yMax = 7;      // Position maximum sur l'axe Y
    void Start()
    {
       
    }
    private void InstantiateVaisseau() {
        float randomY = Random.Range(_yMin, _yMax);
        Vector3 randomPosition = new Vector3(16, randomY, 0);
        // GameObject Vaisseau = GameObject.Find("Vaisseau");
        GoRight myNewObject = Instantiate(_InstantiatePrefab, randomPosition, Quaternion.Euler(0, 0, 180), transform);
        myNewObject.InitializeVelocity();
        Destroy(myNewObject.gameObject, 6f);
    }
    // Update is called once per frame
    void Update()
    { _timer += Time.deltaTime;
        if (_timer > _delay) { 
                InstantiateVaisseau();
                _timer = 0;
        }
    }
   

       
        
        
}

