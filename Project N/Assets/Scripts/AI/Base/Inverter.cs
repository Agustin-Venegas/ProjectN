using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT
{
	public class Inverter : DecoratorNode
	{
		public Node GetNode() {return child;}
		
		public Inverter(Node n) 
		{
			child = n;
		}
		
		public override NodeReturn Evaluar()
		{
			NodeReturn n = child.Evaluar();
			switch (n.state)
			{
				case NodeStates.RUNNING:
				return n;
				
				case NodeStates.FAILURE:
				n.state = NodeStates.SUCCESS;
				break;
				
				case NodeStates.SUCCESS:
				n.state = NodeStates.FAILURE;
				break;
				
				default:
				n.state = NodeStates.SUCCESS;
				break;
			}
			
			return n;
		}
	}
}