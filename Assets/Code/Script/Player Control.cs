using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody myRigidBody;
    float horizontal;
    float vertical;
    Vector3 vec;
    public float speed;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float incline;
    float timer;
    public float fireDelay;
    public GameObject bullet;
    public Transform bulletFirePoint;
    AudioSource audio;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        timer += Time.deltaTime;   //Her bullet arasina belli bir delay eklemek icin algoritma
        if (Input.GetButton("Fire1") && timer >= fireDelay)
        {
            timer = 0;
            Instantiate(bullet, bulletFirePoint.position, Quaternion.identity);
            audio.Play(); // sese ozel fonksiyon
        }
    }
    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal, 0f, vertical);
        myRigidBody.velocity = vec * speed; //objeme kuvvet degil hiz eklemek istiyorum o yuzden velocity kullandim 
        myRigidBody.position = new Vector3(Mathf.Clamp(myRigidBody.position.x, minX, maxX), 0f, Mathf.Clamp(myRigidBody.position.z, minZ, maxZ));
        //Rigidbody ninde bir posisyonu vardir player objem ekranimdan cikmasin diye haraketini kisitliyorum 
        myRigidBody.rotation = Quaternion.Euler(0, 0, myRigidBody.velocity.x * -incline); //player saga giderken saga dogru egilsin sola da ayni sekilde 
        // z ekseninde velocity neden kullandik ??????

    }
}
