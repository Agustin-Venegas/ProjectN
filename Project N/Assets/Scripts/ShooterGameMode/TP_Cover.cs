using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//causa que el jugador se arrodille y reciba menos daño

public class TP_Cover : MonoBehaviour, IHurtable
{
	
	[Header("Atributos")]
	public int HP = 1; //si es -1, es invencible
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D other)
	{
		 if (other.gameObject.GetComponentInChildren<TP_Player>() != null)
        {
            TP_Player.Instance.Kneel();
        }
	}
	
	public bool IsAlive() {return HP>0 || HP == -1;}
	public bool Hurt(int d) {HP -= d; return !IsAlive();}
	public void Die() 
	{
		
	}
}
