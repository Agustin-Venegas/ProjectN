using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//encargado de atacar

public class TP_PlayerAttack : MonoBehaviour
{
	[Header("Partes")]
    public Transform firePoint;
	public GameObject bullet;
	
	private Vector2 mousePos;
	public Camera cam;
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //click izquierdo
		{
			Instantiate(bullet, firePoint.position, firePoint.rotation);
		}
		
		mousePos = cam.ScreenToWorldPoint(Input.mousePosition); //posicion del mouse respecto a la camara 
		Vector2 lookDir = mousePos - (Vector2)firePoint.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f; //arctangente de (y,x)
        firePoint.rotation = Quaternion.Euler(0,0,angle);
    }
}
