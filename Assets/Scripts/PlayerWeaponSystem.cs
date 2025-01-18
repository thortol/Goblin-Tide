using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponSystem : MonoBehaviour
{
    public GameObject currWeapon;

    public float fireRate = 0.25f;

    private float shootBounceTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shootBounceTime <= 0.0f)
        {
            shootBounceTime = fireRate;
            Instantiate(currWeapon, transform.position, transform.rotation);
        }
        shootBounceTime -= Time.deltaTime;
    }
}
