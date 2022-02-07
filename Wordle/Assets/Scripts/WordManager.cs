using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordManager : MonoBehaviour
{
    [SerializeField] private string origin;

	public List<StateType> GetStates(string msg)
	{
		var result = new List<StateType>();

		var list = origin.ToCharArray().ToList();
		var listCurrent = msg.ToCharArray().ToList();

		for (var i = 0; i < listCurrent.Count; i++)
		{
			var currentChar = listCurrent[i];
			var contains = list.Contains(currentChar);
			if (contains)
			{
				var index = list.FindIndex(x => x == currentChar);
				var isCorrect = index == i;
				result.Add(isCorrect ? StateType.Correct : StateType.Present);
			}
			else
			{
				result.Add(StateType.Absent);
			}
		}
		
		return result;
	}
}
