using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//encargado de atacar

public class TP_PlayerAttack : MonoBehaviour
{
	[Header("Partes")]
    public Transform firePoint;
	public GameObject bullet;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) 
		{
			Instantiate(bullet, firePoint.position);
		}
    }
}
