using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourTree
{
	public class Inverter : Node
	{
		private Node node;
		public Node GetNode() {return node;}
		
		public Inverter(Node n) 
		{
			node = n;
		}
		
		public override NodeStates Evaluar()
		{
			switch (node.Evaluar())
			{
				case NodeStates.RUNNING:
				actualState = NodeStates.RUNNING;
				break;
				
				case NodeStates.FAILURE:
				actualState = NodeStates.SUCCESS;
				break;
				
				case NodeStates.SUCCESS:
				actualState = NodeStates.FAILURE;
				break;
				
				default:
				actualState = NodeStates.SUCCESS;
				break;
			}
			
			return actualState;
		}
	}
}