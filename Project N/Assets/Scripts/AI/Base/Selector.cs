using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviourTree
{
	//Selector: Ejecuta los hijos hasta que uno regrese SUCCESS
	//Si ninguno tira SUCCESS, regresa FAILURE
	
	public class Selector : Node
	{
		protected List<Node> nodes = new List<Node>();
		
		public Selector(List<Node> n) 
		{
			nodes = n;
		}
		
		public override NodeStates Evaluar() 
		{ 
			foreach (Node node in nodes)
			{ 
				switch (node.Evaluar())
				{ 
                case NodeStates.FAILURE: 
                    continue;
                case NodeStates.SUCCESS: 
                    actualState = NodeStates.SUCCESS; 
                    return actualState; 
                case NodeStates.RUNNING: 
                    actualState = NodeStates.RUNNING; 
                    return actualState; 
                default: 
                    continue; 
				} 
			} 
			actualState = NodeStates.FAILURE; 
			return actualState; 
		} 
	}
}