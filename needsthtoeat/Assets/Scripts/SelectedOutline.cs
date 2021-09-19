using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedOutline : MonoBehaviour
{

    public GameObject selectedObject;
    public bool lookingAtObject = false;

    // Update is called once per frame
    void Update()
    {
        if (lookingAtObject == true) 
        {
            //give object outline and UI
        }
    }

    void OnMouseOver()
    {
        selectedObject = GameObject.Find(CastingToObject.selectedObject);
        lookingAtObject = true;
        

    }

    void OnMouseExit()
    {
        lookingAtObject = false;    
    }

}
