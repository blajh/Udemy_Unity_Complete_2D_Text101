using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	[SerializeField]
	private TMP_Text storyText;

	[SerializeField]
	private State startingState;

	private State currentState;

    void Start()
    {
		currentState = startingState;
        storyText.text = currentState.GetStateStory();
    }

    void Update()
    {
        
    }
}
