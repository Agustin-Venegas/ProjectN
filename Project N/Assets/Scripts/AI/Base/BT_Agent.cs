using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT;

//clase para heredar. Define algunas cosas utiles
//como funciones
public class BT_Agent : MonoBehaviour
{
	
	[Header("BehaviourTree")]
	public BehaviourTree Controller;
	
    void Start()
    {
        Controller = new BehaviourTree();
		Controller.root = new ConditionNode(CheckDistanceToPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public bool CheckDistanceToPlayer()
	{
		//float v = Vector3.Distance(this.transform.position, other.position);
		return true;
	}
}
