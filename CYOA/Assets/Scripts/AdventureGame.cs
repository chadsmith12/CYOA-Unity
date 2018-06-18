using System;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text _textComponent;
    [SerializeField] private State _startingState;

    private State _state;

	// Use this for initialization
	void Start ()
    {
        _state = _startingState;
        _textComponent.text = _state.StoryText;
	}
	
	// Update is called once per frame
	void Update ()
    {
        ManageState();
	}

    private void ManageState()
    {
        var nextStates = _state.NextStates;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _state = nextStates[2];
        }

        _textComponent.text = _state.StoryText;
    }
}
