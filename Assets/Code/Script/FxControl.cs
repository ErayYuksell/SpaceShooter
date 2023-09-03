using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxControl : MonoBehaviour
{
    Rigidbody myRigidBody;
    public float bulletSpeed;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
       
    }

    private void Update()
    {
        myRigidBody.velocity = transform.forward * bulletSpeed; //update e yazmama gerek yok objenin hizina ileri dogru 1 kere hareket verdim mi ileri dogru surekli gidecek zaten
        //adam ustteki gibi soyledi ama starta alirsam bu codu hizi kadar yer kat edip kaliyor amk ?????????
    }

}
