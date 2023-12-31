using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Archer Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
        }

        // Ekran�n �st s�n�r�n� belirle
        float topScreenY = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

        // Ku� ekran�n �st�ndeyse oyunu sonland�r
        if (transform.position.y > topScreenY && birdIsAlive)
        {
            logic.gameOver();
            birdIsAlive = false;
        }

        // Ekran�n alt s�n�r�n� belirle
        float bottomScreenY = Camera.main.ViewportToWorldPoint(Vector3.zero).y;

        // Ku� ekran�n alt�ndaysa oyunu sonland�r
        if (transform.position.y < bottomScreenY && birdIsAlive)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
