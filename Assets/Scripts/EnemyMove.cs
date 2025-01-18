using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Vector3 stepAmount = new Vector3(-1, 0, 0);
    public int damage = 1;
    public float lastInstance;
    public float damageInstance = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        lastInstance = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update() 
    { 
        gameObject.transform.position = gameObject.transform.position + (stepAmount * Time.deltaTime);
        if (stepAmount == Vector3.zero && Time.realtimeSinceStartup - lastInstance > damageInstance)
        {
            GameManager.instance.SetWallHp(GameManager.instance.GetWallHp() - damage);
            lastInstance = Time.realtimeSinceStartup;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall")) 
        {
            stepAmount = Vector3.zero;
        }
    }
}
