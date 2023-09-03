using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public GameObject AsteroidPrefab;
    public Vector3 randomPosition;
    public Text text;
    public Text gameOverText;
    public Text startAgainText;
    int score;
    bool gameOverControl = false;
    bool startAgain = false;
    void Start()
    {
       
        score = 0;
        /*text.text = "Score =" + score;*/ //nasil surekli degisiyor bu update almam gerekmezmi ?????????
        StartCoroutine(olustur());
    }
    private void Update()
    {
        text.text = "Score =" + score;
        if (Input.GetKeyDown(KeyCode.R) && startAgain)
        {
            SceneManager.LoadScene("level 1"); //bu code ile sahnemiz yeniden baslatilacak
        }
    }
    IEnumerator olustur() //Asteroid olusumlari arasina delay eklemek icin Coroutine kullandim 
    {
        yield return new WaitForSeconds(4); //Oyun basladiginda Donguye girmeden 2 saniye bekletiyorum
        //Izledigim adam burda sayi yazan yerlere public degisken atadi editorden etki edebilmek icin ama ben koymadim
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPosition.x, randomPosition.x), 0, randomPosition.z);
                Instantiate(AsteroidPrefab, vec, Quaternion.identity);
                yield return new WaitForSeconds(.5f); //0.7 saniye bekle diyorum
            }
            if (gameOverControl) //player bir asteroidle carpistiginda buraya girer
            {
                startAgainText.text = "Press R to restart";
                startAgain = true;
                break;
            }
            yield return new WaitForSeconds(2);
            //for dongusune 10 kere girdikten sonra 2 saniye bekler ve while dongusune tekrar girer sonsuz dongu seklinde taslar 10 lu sekilde uretilir
           

        }


    }
    public void increaseScore(int getScore)
    {
        score += getScore;
        Debug.Log(score);
    }
    public void gameOver()
    {
        Debug.Log("Game Over");
        gameOverText.text = "Game Over";
        gameOverControl = true;
    }
    


}
