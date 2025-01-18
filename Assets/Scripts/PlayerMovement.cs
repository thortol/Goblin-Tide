using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(0f, movementSpeed * Time.deltaTime, 0f);
        }
        else if(Input.GetKey(KeyCode.S))
        {
			gameObject.transform.position -= new Vector3(0f, movementSpeed * Time.deltaTime, 0f);
		}
    }
}