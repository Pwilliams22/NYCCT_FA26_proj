using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;


    public GameObject currentPlayer;
    public SpriteRenderer playerSprite;
    public float playerHealth = 5;
    public float score = 0;
    public float timer = 0;
    public GameObject coin;

    public string startText = "Hello World";
    // Start is called once before the first execution of Update after this script gets loaded into your game scene
   
    
    
    void Start()
    {
        Debug.Log(startText);

        currentPlayer = GameObject.Find("Player");
        playerSprite = GameObject.Find("Player").GetComponent<SpriteRenderer>();
        playerSprite.color = Color.white;
    }
    void Update()
    {
        if(playerHealth <= 0 )
        { 
            playerSprite.color = Color.red;
            currentPlayer.GetComponent<wasd>().enabled = false;
        }



        timer += Time.deltaTime;
        if(timer > 3f) //for a repeating timer, just reset timer when it hits the limit
        {
            Vector2 pos;
            pos.x = Random.Range(-9, 9);
            pos.y = Random.Range(-4, 5);
            Instantiate(coin, pos, Quaternion.identity);
            timer = 0;
        }
    }


    public void ChangePlayerHealth(float health)
    {
        playerHealth = health;
    }
}
