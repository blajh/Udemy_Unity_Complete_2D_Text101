using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="state")]
public class State : ScriptableObject
{
	[TextArea(10,14)]
	[SerializeField]
	private string storyText;



}
