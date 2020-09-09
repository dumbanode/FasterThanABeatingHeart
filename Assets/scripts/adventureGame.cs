using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventureGame : MonoBehaviour
{

    [SerializeField] Text choice1;
    [SerializeField] Text choice2;

    [SerializeField] Text textComponent;
    [SerializeField] state startingState;

    state currentState;
    characterBehaviour charBehav;
    backdropBehaviour bdB;

    [SerializeField] Button choice1Button;
    [SerializeField] Button choice2Button;



    // Start is called before the first frame update
    void Start()
    {
        currentState = startingState;
        textComponent.text = currentState.getStateStory();

        //set up the background
        GameObject backdrop = GameObject.Find("backdrop");
        bdB = backdrop.GetComponent<backdropBehaviour>();

        //set up the character
        GameObject character = GameObject.Find("character");
        charBehav = character.GetComponent<characterBehaviour>();

        //set up the choice buttons
        //GameObject choiceButtons = GameObject.Find("selectButtons");
        //buttonBehav = choiceButtons.GetComponent<selectionHandler>();

        updateAll();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void nextState()
    {
        var nextStates = currentState.getNextStates();
        currentState = nextStates[0];
        textComponent.text = currentState.getStateStory();
        updateAll();
    }

    public void updateState(int index){
        var nextStates = currentState.getNextStates();
        currentState = nextStates[index];
        textComponent.text = currentState.getStateStory();
        updateAll();
    }

    public void prevState()
    {
        state previousState = currentState.getPrevState();
        if (previousState != null){
            currentState = currentState.getPrevState();
            textComponent.text = currentState.getStateStory();
            updateAll();
        }
    }

    public state getCurrentState()
    {
        return currentState;
    }

    public void updateAll()
    {
        updateBackdrop();
        updateCharacter();
        updateChoiceButtons();
    }

    public void updateBackdrop()
    {
        bdB.updateBackdrop(currentState);
    }

    public void updateCharacter()
    {
        charBehav.updateCharacter(currentState);
    }

    public void updateChoiceButtons(){
        if (currentState.getChoice1Text() == "NULL"){
            //no choice to choose from, disable the button
            choice1Button.enabled = false;
            choice1Button.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            choice1Button.GetComponentInChildren<Text>().color = Color.clear;
        } else {
            choice1Button.enabled = true;
            choice1Button.GetComponentInChildren<CanvasRenderer>().SetAlpha(100);
            choice1Button.GetComponentInChildren<Text>().color = Color.black;
            choice1.text = currentState.getChoice1Text();
        }
        //choice1.text = currentState.getChoice1Text();
        //Debug.Log("Inside updateChoice");
        if (currentState.getChoice2Text() == "NULL"){
            //no choice to choose from, disable the button
            choice2Button.enabled = false;
            choice2Button.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            choice2Button.GetComponentInChildren<Text>().color = Color.clear;
        } else {
            choice2Button.enabled = true;
            choice2Button.GetComponentInChildren<CanvasRenderer>().SetAlpha(100);
            choice2Button.GetComponentInChildren<Text>().color = Color.black;
            choice2.text = currentState.getChoice2Text();
        }
    }
}
