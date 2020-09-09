using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu (menuName ="state")]
public class state : ScriptableObject
{


    [TextArea(14,30)][SerializeField] string storyText;
    [SerializeField] string choice1Text;
    [SerializeField] string choice2Text;
    [SerializeField] state[] nextStates;
    [SerializeField] Sprite character;
    [SerializeField] Sprite backdrop;
    [SerializeField] state previousState = null;



    public string getStateStory()
    {
        return storyText;
    }

    public string getChoice1Text(){
        return choice1Text;
    }

    public string getChoice2Text(){
        return choice2Text;
    }

    public state[] getNextStates()
    {
        return nextStates;
    }

    public state getPrevState(){
        return previousState;
    }

    public Sprite getBackdrop()
    {
        return backdrop;
    }

    public Sprite getCharacter()
    {
        return character;
    }
}
