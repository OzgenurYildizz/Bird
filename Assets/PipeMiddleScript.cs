using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //runtimeda bizim belirledi�imiz tagi bulucak
    }//pipemiddlescript->logicscriptle konu�abilcek

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==3) //sadece ku� layer� �arpt���nda arts�n
        {
            logic.addScore(1); //Fonksiyonun daha �ok y�nl� olmas�n� sa�lar 
        }
       
    }
}
