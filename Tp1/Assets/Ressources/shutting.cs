using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class shutting : MonoBehaviour
{
    [SerializeField] private Transform _Fire;
    [SerializeField] private Transform _Canon;
    [SerializeField] private MoveUp _prefabInstantiate;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private float _delayToDestroy = 5f;
    private float _timer;
    // Update is called once per frame
    private void InstantiateFire()
    { 
        //recupere la postiion du space ship
        Vector3 CanonPosition = _Canon.position + _Canon.up * 1.0f;
        Quaternion CanonRotation = _Canon.rotation;
        MoveUp myNewObject = Instantiate(_prefabInstantiate, CanonPosition, CanonRotation, _Fire);
        myNewObject.InitializeVelocity();
        Destroy(myNewObject.gameObject, _delayToDestroy);
    }
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            InstantiateFire();
            _timer = 0;
        }
    }
}


