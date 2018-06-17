using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text _textComponent; 

	// Use this for initialization
	void Start ()
    {
        _textComponent.text = "Our amazing story!";
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
