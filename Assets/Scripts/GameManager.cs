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
	private State[] nextStates;

    void Start()
    {
		currentState = startingState;
		GetStates();
		UpdateScreen();
	}

    void Update()
    {
		ListenForInput();
    }

	private void ListenForInput() {

		for (int i = 0; i < nextStates.Length; i++) {

			if (Input.GetKeyDown(KeyCode.Alpha1 + i)) {
				UpdateState(i);
			}
		}
	}

	private void GetStates() {
		nextStates = currentState.GetNextStates();
	}

	private void UpdateState(int index) {
		GetStates();
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
