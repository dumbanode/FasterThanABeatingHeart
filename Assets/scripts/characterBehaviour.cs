using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateCharacter(state state)
    {
        Image myCharacter = GetComponent<Image>();
        if (state.getCharacter())
        {
            
            myCharacter.enabled = true;
            myCharacter.sprite = state.getCharacter();
        } else
        {
            myCharacter.enabled = false;
        }
    }
}
