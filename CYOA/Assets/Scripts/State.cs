using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)]
    [SerializeField]
    private string _storyText;
    [SerializeField]
    private State[] _nextStates;

    /// <summary>
    /// The story text to print out for this current state.
    /// </summary>
    public string StoryText
    {
        get
        {
            return _storyText;
        }
    }

    /// <summary>
    /// Gets the next states that you can go to from this state.
    /// </summary>
    public State[] NextStates
    {
        get
        {
            return _nextStates;
        }
    }
}
