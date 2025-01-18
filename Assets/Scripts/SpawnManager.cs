using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject goblin;
    private BoxCollider2D box;
    private float low;
    private float high;

    void Start()
    {
        box = gameObject.GetComponent<BoxCollider2D>();
        low = box.bounds.center.y - box.bounds.size.y/2;
        high = box.bounds.center.y + box.bounds.size.y/2;
    }

    public void spawn()
    {
        Instantiate(goblin, new Vector3(box.bounds.center.x, Random.Range(low, high), box.bounds.center.z), goblin.transform.rotation);
    }
}
