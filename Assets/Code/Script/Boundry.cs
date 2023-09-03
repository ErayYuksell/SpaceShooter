using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundry : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
            Destroy(other.gameObject); // Scene ucuna bir box collider ekledim sinir olarak onla temas eden objeler yok oluyor performans daha iyi olsun diye
    }
}
