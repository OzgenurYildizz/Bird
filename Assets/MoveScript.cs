using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        //transform.position = transform.position + (Vector3.left * moveSpeed);

        if (transform.position.x < deadZone)//Geride kalan borularin silinmesi icin
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
