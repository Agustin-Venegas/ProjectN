using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT
{
	//Selector: Ejecuta los hijos hasta que uno regrese SUCCESS
	//Si ninguno tira SUCCESS, regresa FAILURE
	public class Selector : CompositeNode
	{
		public Selector(List<Node> n) 
		{
			nodes = n;
		}
		
		public override NodeReturn Evaluar() 
		{
			NodeReturn n;
			
			foreach (Node node in nodes)
			{
				n = node.Evaluar();
				switch (n.state)
				{ 
                case NodeStates.FAILURE: 
                    continue;
                case NodeStates.SUCCESS: 
                    actualState = NodeStates.SUCCESS; 
                    return n; 
                case NodeStates.RUNNING: 
                    actualState = NodeStates.RUNNING; 
                    return n; 
                default: 
                    continue; 
				} 
			}
			
			actualState = NodeStates.FAILURE;
			n = new NodeReturn(actualState);
			
			return n; 
		}
	}
}