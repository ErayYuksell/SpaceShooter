using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
    Rigidbody myRigidBody;
    public float asteroidSpeed;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.angularVelocity = Random.insideUnitCircle * asteroidSpeed;
        //angularVelocity = acisal hiz - pozisyonda bir degisiklik olmaz rotasyonunda degisiklik olur 
        //her oyun basladiginda random bir sekilde doner
    }


    void Update()
    {
        
    }
}
