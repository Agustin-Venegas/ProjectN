﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TP_Player : MonoBehaviour, IHurtable
{
	public static TP_Player Instance;
	
	[Header("Estadisticas Primarias")]
    public int HP_Max;
	public float speed;
    private int hp;
	private bool kneeling;

	
	[Header("HUD Prefabs")]
	public GameObject pause;
	
	void Awake() 
	{
		Instance = this;
	}
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		if (Input.GetKey(KeyCode.A)) 
		{
			transform.position = new Vector3(transform.position.x-speed*Time.deltaTime, transform.position.y, transform.position.z);
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			transform.position = new Vector3(transform.position.x+speed*Time.deltaTime, transform.position.y, transform.position.z);
		}
    }
	
	
	public bool IsAlive() {return hp>0;}
	public bool Hurt(int d) {hp -= d; return !IsAlive();}
	public void Die() 
	{
		
	}

	public void Kneel()
	{
		kneeling = true;
	}
}
