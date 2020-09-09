using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backdropBehaviour : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateBackdrop(state state)
    {
        Image myBackdrop = GetComponent<Image>();
        myBackdrop.sprite = state.getBackdrop();
    }

}
