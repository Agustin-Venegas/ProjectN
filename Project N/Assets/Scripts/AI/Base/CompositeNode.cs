using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT 
{
	public abstract class CompositeNode : Node
	{
		protected List<Node> nodes = new List<Node>();
		
	}
}