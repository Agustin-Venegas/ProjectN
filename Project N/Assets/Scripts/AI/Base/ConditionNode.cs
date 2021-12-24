using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT
{
	//un nodo que ejecuta una funcion (delegado) y regresa si es true o no
	//no deberia regresar RUNNING nunca
	public class ConditionNode : Node
	{
		public delegate bool ConditionDelegate();
		
		private ConditionDelegate condition;
		
		public ConditionNode(ConditionDelegate c)		
		{
			condition = c;
		}
		
		public override NodeReturn Evaluar()
		{
			NodeStates r = condition() ? NodeStates.SUCCESS : NodeStates.FAILURE;
			return new NodeReturn(r);
		}
	}
}