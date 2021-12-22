using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourTree
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
		
		public override NodeStates Evaluar()
		{
			//se ejecuta y returna el action
			switch (m_action())
			{
				case NodeStates.SUCCESS:
				actualState = NodeStates.SUCCESS;
				return actualState;
				
				case NodeStates.FAILURE:
				actualState = NodeStates.FAILURE;
				return actualState;
				
				case NodeStates.RUNNING:
				actualState = NodeStates.RUNNING;
				return actualState;
				
				//esto es importante, el comportamiento default
				default:
				actualState = NodeStates.FAILURE;
				return actualState;
			}
		}
	}
}