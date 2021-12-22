using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourTree
{
	//Secuencia: Ejecuta todos los nodos hijos hasta que uno falla
	//Los que estan corriendo van a seguir corriendo
	
	public class Secuencia : Node
	{
		
		protected List<Node> nodes = new List<Node>();
		
		public Secuencia(List<Node> n) 
		{
			nodes = n;
		}		
		
		public override NodeStates Evaluar() 
		{
			bool any_running = false;
			
			foreach (Node node in nodes)
			{ 
				switch (node.Evaluar())
				{ 
                case NodeStates.SUCCESS: 
                    continue;
                case NodeStates.FAILURE: 
                    actualState = NodeStates.FAILURE; 
                    return actualState; 
                case NodeStates.RUNNING: 
                    any_running = true;
					continue;
                default: 
                    continue; 
				} 
			}
			
			actualState = any_running ? NodeStates.RUNNING : NodeStates.SUCCESS;
			return actualState; 
		}
	}
}