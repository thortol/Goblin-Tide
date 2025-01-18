using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Vector3 stepAmount = new Vector3(-1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update() 
    { 
        gameObject.transform.position = gameObject.transform.position + (stepAmount * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall")) 
        {
            stepAmount = Vector3.zero;
        }
    }
}
