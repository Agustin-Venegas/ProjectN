using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT
{
	
	//un nodo que ejecuta una funcion (delegado)
	public class ActionNode : Node
	{
		
		//el delegado es un tipo devolver si o si un NodeStates		
		public delegate NodeStates ActionNodeDelegate();
		
		private ActionNodeDelegate m_action;
		
		public ActionNode(ActionNodeDelegate action)
		{
			m_action = action;
		} 
		
		public ActionNode() 
		{
			
		}
		
		public override NodeReturn Evaluar()
		{
			NodeReturn n = new NodeReturn();
			
			//se ejecuta y returna el action
			switch (m_action())
			{
				case NodeStates.SUCCESS:
				n.state = NodeStates.SUCCESS;
				break;
				
				case NodeStates.FAILURE:
				n.state = NodeStates.FAILURE;
				break;
				
				case NodeStates.RUNNING:
				n.state = NodeStates.RUNNING;
				n.node = this;
				break;
				
				//esto es importante, el comportamiento default
				default:
				n.state = NodeStates.FAILURE;
				break;
			}
			
			return n;
		}
	}
}