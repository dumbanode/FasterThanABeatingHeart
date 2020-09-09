using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHandler : MonoBehaviour
{
    public void nextState()
    {
        adventureGame adventureGame;
        GameObject gameLogic = GameObject.Find("gameLogic");
        adventureGame = gameLogic.GetComponent<adventureGame>();
        adventureGame.nextState();
    }

}
