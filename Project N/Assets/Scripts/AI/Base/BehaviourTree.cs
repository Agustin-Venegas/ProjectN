using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT;

public class BehaviourTree
{
	
	[Header("Tree Vars")]
	public bool Thinking = true; //si está funcionando
	public float frequency = 0.3f;
	
	public Node root;
	
	private IEnumerator Think()
	{
		NodeReturn val = new NodeReturn();
		
		while (Thinking) 
		{
			yield return new WaitForSeconds(0.5f);
			
			if (val.state == NodeStates.RUNNING)
			{
				val = val.node.Evaluar();
			} else 
			{
				val = root.Evaluar();
			}
		}
	}
}
