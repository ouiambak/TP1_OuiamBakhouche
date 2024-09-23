using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Shut : MonoBehaviour
{
    [SerializeField]private Transform _LaserBalle;
    [SerializeField] private Transform Ship;
    [SerializeField] private MoveUp _prefabInstantiate;
    [SerializeField] private float _delay = 1f;
    [SerializeField] private float _delayToDestroy = 6f;
    private float _timer;
    private int _VaisseauDead;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    private void InstantiateBalle()
    {


        //recupere la postiion du space ship
        Vector3 ShipPosition = Ship.position + Ship.up * 1.0f;
        Quaternion Shiprotation = Ship.transform.rotation;
        MoveUp myNewObject = Instantiate(_prefabInstantiate, ShipPosition, Shiprotation, _LaserBalle);
        myNewObject.InitializeVelocity();
        Destroy(myNewObject.gameObject, _delayToDestroy);
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { // Appeler l'instanciation plusieurs fois 
            InstantiateBalle();
        }
    }
}
