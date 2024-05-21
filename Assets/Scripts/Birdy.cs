using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2d;
    public bool isDead;
    public GameObject DeathScreen;
    public GameManager managergame;
     void Update ()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            rb2d.velocity = Vector2.up * velocity; 
        
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="ScoreArea")
        {
            managergame.UpdateScore();
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        } 
    }






}
