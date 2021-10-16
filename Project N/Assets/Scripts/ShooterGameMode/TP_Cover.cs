using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


//causa que el jugador se arrodille y reciba menos daño

public class TP_Cover : MonoBehaviour, IHurtable
{
	
	[Header("Atributos")]
	public int HP = 1; //si es -1, es invencible
	
	[Header("Partes")]
	public Transform firepoint;
	
	[Header("Evento Destruir")]
	public UnityEvent OnDie;
	
	
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
		if (other.gameObject.GetComponent<TP_Player>() != null)
        {
            TP_Player.Instance.Kneel(firepoint);
        }
	}
	
	void OnTriggerExit2D(Collider2D other) 
	{
		if (other.gameObject.GetComponent<TP_Player>() != null)
        {
            TP_Player.Instance.StopKneel();
        }
	}
	
	public bool IsAlive() {return HP>0 || HP == -1;}
	public bool Hurt(int d) {HP -= d; if (IsAlive()) { return false; } else {Die(); return true;}}
	public void Die() 
	{
		OnDie.Invoke();
	}
}
