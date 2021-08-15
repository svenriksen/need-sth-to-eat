using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingToObject : MonoBehaviour
{

    public static string selectedObject;
    public string internalObject;
    public RaycastHit theObject;
    
    private Animator anim;

    private bool drawerOpened = false;
    private bool doorOpened = false;


    public float maxDistance = 3;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theObject, maxDistance))
        {
            selectedObject = theObject.transform.gameObject.name;
            internalObject = theObject.transform.gameObject.name;

        }


        //This will tell if the player press F on the Keyboard. P.S. You can change the key if you want.
        if (Input.GetKeyDown(KeyCode.F))
        {
            Pressed();
            //Delete if you dont want Text in the Console saying that You Press F.
        }
    }
    void Pressed()
    {

        string objTag = theObject.transform.tag;
        


        // if raycast hits, then it checks if it hit an object with the tag Door.
        if (theObject.transform.tag == "Drawer")
        {

            //This line will get the Animator from  Parent of the door that was hit by the raycast.
            anim = theObject.transform.GetComponentInParent<Animator>();

            //This will set the bool the opposite of what it is.
            drawerOpened = !drawerOpened;

            //This line will set the bool true so it will play the animation.
            anim.SetBool("drawerOpened", !drawerOpened);
        }

        

        if (theObject.transform.tag == "Door")
        {

            //This line will get the Animator from  Parent of the door that was hit by the raycast.
            anim = theObject.transform.GetComponentInParent<Animator>();

            //This will set the bool the opposite of what it is.
            doorOpened = !doorOpened;

            //This line will set the bool true so it will play the animation.
            anim.SetBool("doorOpened", !doorOpened);
        }


    }
}
