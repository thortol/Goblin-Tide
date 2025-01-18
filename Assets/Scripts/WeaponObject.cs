using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponObject : MonoBehaviour
{
	private Rigidbody2D rb;
	public Transform trf;
	public Sprite img;


	private void Awake()
	{
		rb = gameObject.GetComponent<Rigidbody2D>();
		
	}

	// Start is called before the first frame update
	void Start()
	{
		rb.AddForce(new Vector2(100.0f, 0.0f));
	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log(GameManager.instance.GetWallHp());
	}

	IEnumerator doDamage()
	{
		yield break;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("enemy"))
		{
			Debug.Log("Byebye");
			this.gameObject.SetActive(false);
		}
	}

}
