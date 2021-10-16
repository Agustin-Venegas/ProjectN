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

	[Header("Partes")]
	public Animator anim;
	
	[Header("HUD Prefabs")]
	public GameObject pause;
	
	void Awake() 
	{
		Instance = this;
	}
	
    void Start()
    {
        if (anim == null)
		{
			anim = gameObject.GetComponent<Animator>();
		}
    }

    // Update is called once per frame
    void Update()
    {
		bool moving = false;
		
		if (Input.GetKey(KeyCode.A) && !kneeling) 
		{
			if (!kneeling)
			{
				transform.position = new Vector3(transform.position.x-speed*Time.deltaTime, transform.position.y, transform.position.z);
				moving = true;
			}
			
			anim.SetBool("right", false);
		} else
		if (Input.GetKey(KeyCode.D) && !kneeling) 
		{
			if (!kneeling)
			{
				transform.position = new Vector3(transform.position.x+speed*Time.deltaTime, transform.position.y, transform.position.z);
				moving = true;
			}
			
			anim.SetBool("right", true);
		}
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (kneeling) 
			{
				kneeling = false;
			}
		}
		
		
		anim.SetBool("kneel", kneeling);
		anim.SetBool("moving", moving);
    }
	
	
	public bool IsAlive() {return hp>0;}
	public bool Hurt(int d) {hp -= d; return !IsAlive();}
	public void Die() 
	{
		anim.SetBool("alive", false);
	}

	public void Kneel()
	{
		kneeling = true;
		anim.SetBool("moving", false);
	}
	
	public void StopKneel()
	{
		kneeling = false;
	}
}
