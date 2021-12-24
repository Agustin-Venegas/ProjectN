using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT 
{
	public enum NodeStates
	{
		FAILURE,
		SUCCESS,
		RUNNING
	}
	
	public sealed class NodeReturn
	{
		public NodeStates state;
		public Node node;
		
		public NodeReturn()
		{
			//default
			state = NodeStates.FAILURE;
			node = null;
		}
		
		public NodeReturn(NodeStates n)
		{
			state = n;
			node = null;
		}
		
		public NodeReturn(NodeStates n, Node a)
		{
			state = n;
			node = a;
		}
	}
}