using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT
{
	//Secuencia: Ejecuta todos los nodos hijos hasta que uno falla
	//Los que estan corriendo van a seguir corriendo
	
	public class Secuencia : CompositeNode
	{
		public Secuencia(List<Node> n) 
		{
			nodes = n;
		}
		
		public override NodeReturn Evaluar() 
		{
			bool any_running = false;
			
			foreach (Node node in nodes)
			{ 
				switch (node.Evaluar().state)
				{
					
                case NodeStates.SUCCESS: 
                    continue;
					
                case NodeStates.FAILURE: 
                    actualState = NodeStates.FAILURE; 
                    return new NodeReturn(actualState);
					
                case NodeStates.RUNNING: 
                    any_running = true;
					continue;
					
                default: 
                    continue; 
				} 
			}
			
			if (any_running) 
			{
				return new NodeReturn(actualState, this);
			} else 
			{
				return new NodeReturn(actualState);
			}
		}
	}
}