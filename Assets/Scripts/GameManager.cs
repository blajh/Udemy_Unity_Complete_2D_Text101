using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	[SerializeField]
	private TMP_Text storyText;

    void Start()
    {
        storyText.text =	"Operation System v.042 loaded...\n" +
							"User account confirmed...\n" +
							"Full root access... GRANTED!\n" +
							".......loading..............\n" +
							"Dependency packages intalled...\n" +
							"Link to IP address established...\n";
    }

    void Update()
    {
        
    }
}
