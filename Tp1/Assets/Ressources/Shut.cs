using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Shut : MonoBehaviour
{
    [SerializeField]private Transform _LaserBalle;
    [SerializeField] private Transform Ship;
    [SerializeField] private MoveUp _prefabInstantiate;
    [SerializeField] private float _delay = 2f;
    [SerializeField] private float _delayToDestroy = 6f;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void InstantiateBalle()
    {


        //recupere la postiion du space ship
        Vector3 ShipPosition = Ship.position + Ship.up * 1.0f;
        MoveUp myNewObject = Instantiate(_prefabInstantiate, ShipPosition, Quaternion.Euler(0, 0, 180), _LaserBalle);
        myNewObject.InitializeVelocity();
        Destroy(myNewObject.gameObject, 6f);
    }
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _delay)
        { 
            if(Input.GetKey(KeyCode.Space))
            { // Appeler l'instanciation plusieurs fois 
                InstantiateBalle();
            }
            _timer = 0;
        }
    }
}
