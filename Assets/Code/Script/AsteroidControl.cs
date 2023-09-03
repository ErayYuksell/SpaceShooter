using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidControl : MonoBehaviour
{
   
    Rigidbody myRigidBody;
    public float asteroidSpeed; //bulletten farki uzay gemisine dogru haraket etmesi icin - deger verdik
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.velocity = transform.forward * asteroidSpeed;
    }

    private void Update()
    {
        
    }
}
