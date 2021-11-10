using System.Collections;
using UnityEngine;

namespace BehaviourTree
{
	
	//nodo generico. Todos los nodos heredan de esto
	
	[System.Serializable]
	public abstract class Node
	{
		
		protected NodeStates actualState;
		
		public delegate NodeStates Return();
		
		public Node() {}
		
		public abstract NodeStates Evaluar();
		
	}
}