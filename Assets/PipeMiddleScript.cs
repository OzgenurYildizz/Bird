using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //runtimeda bizim belirlediðimiz tagi bulucak
    }//pipemiddlescript->logicscriptle konuþabilcek

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==3) //sadece kuþ layera çarptýðýnda artsýn
        {
            logic.addScore(1); //Fonksiyonun daha çok yönlü olmasýný saðlar 
        }
       
    }
}
