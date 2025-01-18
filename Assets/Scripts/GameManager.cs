using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int wallHp = 100;
	// Start is called before the first frame update

	private void Awake()
	{
        instance = new GameManager();
	}

	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetWallHp(int setthis)
    {
        wallHp = setthis;
    }

    public int GetWallHp()
    {
        return wallHp;
    }

}
