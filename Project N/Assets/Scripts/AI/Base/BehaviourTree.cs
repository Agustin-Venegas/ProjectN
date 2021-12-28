using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT;

[System.Serializable]
public class BehaviourTree
{
	
	[Header("Tree Vars")]
	public bool thinking = true; //si está funcionando
	
	public Node root;
	
	private NodeReturn lastFrame = new NodeReturn();
	
	private void Think()
	{
		if (thinking)
		{
			if (lastFrame.state == NodeStates.RUNNING)
			{
				lastFrame = lastFrame.node.Evaluar();
			} else 
			{
				lastFrame = root.Evaluar();
			}
		}
	}
}
