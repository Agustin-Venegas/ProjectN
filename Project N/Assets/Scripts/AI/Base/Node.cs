using System.Collections;
using UnityEngine;

namespace BT
{
	
	//nodo generico. Todos los nodos heredan de esto
	public abstract class Node
	{
		
		protected NodeStates actualState;
		
		public delegate NodeStates Return();
		
		public Node() {}
		
		public abstract NodeReturn Evaluar();
		
	}
}