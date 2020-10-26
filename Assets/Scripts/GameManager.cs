using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
	public AudioManager audioManager;

	[SerializeField]
	private TMP_Text storyText;

	[SerializeField]
	private State startingState;

	private State currentState;

    void Start()
    {
		currentState = startingState;
		UpdateScreen();
	}

    void Update()
    {
		ListenForInput();
    }

	private void ListenForInput() {
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			UpdateState(0);
		}

		else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			UpdateState(1);
		}
	}

	private void UpdateState(int index) {
		var nextStates = currentState.GetNextStates();
		currentState = nextStates[index];
		UpdateScreen();
		PlayAudio(audioManager.choiceClick);
	}

	private void UpdateScreen() {
		storyText.text = currentState.GetStateStory();
	}

	public void PlayAudio(AudioClip clip) {
		//audioManager.audioSource.clip = clip;
		audioManager.audioSource.PlayOneShot(clip);
	}
}
