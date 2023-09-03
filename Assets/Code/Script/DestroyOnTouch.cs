using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    GameObject gameControl;
    GameControl control;
    private void Start()
    {
        gameControl = GameObject.FindGameObjectWithTag("GameControl");
        control = gameControl.GetComponent<GameControl>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Boundry"))
        {
            Destroy(other.gameObject);  //Mermi carptiginda hem asteroid hemde mermi yok olmasini saglar  
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            control.increaseScore(10);
        }

        if (other.CompareTag("Player")) //bu kisim player asteroidle carpisirsa farkli bir patlama olsuturuyor 
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            control.gameOver();  //bunu burda calistirdigimda gameOverControl = true oluyor ve dongudeki kisma girerek break calisiyor
        }
    }
}
