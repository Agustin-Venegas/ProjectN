using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//un nodo decorador tiene solo un hijo
namespace BT
{
	public abstract class DecoratorNode : Node
	{
		protected Node child;
	}
}
