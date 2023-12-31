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

        // Ekranýn üst sýnýrýný belirle
        float topScreenY = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

        // Kuþ ekranýn üstündeyse oyunu sonlandýr
        if (transform.position.y > topScreenY && birdIsAlive)
        {
            logic.gameOver();
            birdIsAlive = false;
        }

        // Ekranýn alt sýnýrýný belirle
        float bottomScreenY = Camera.main.ViewportToWorldPoint(Vector3.zero).y;

        // Kuþ ekranýn altýndaysa oyunu sonlandýr
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
