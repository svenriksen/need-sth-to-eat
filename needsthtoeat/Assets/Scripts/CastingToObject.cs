using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingToObject : MonoBehaviour
{

    public static string selectedObject;
    public string internalObject;
    public RaycastHit theObject;



    private Animator anim;


    private bool drawerOpened = true;
    private bool drawer1Opened = true;
    private bool drawer2Opened = true;
    private bool doorOpened = true;
    private bool fridgeUpOpened = true;
    private bool fridgeDownOpened = true;
    private bool cabin1Opened = true;
    private bool cabin2Opened = true;
    private bool cabin3Opened = true;
    private bool cabin4Opened = true;
    private bool cabin5Opened = true;
    private bool cabin6Opened = true;

    bool touched;


    public float maxDistance = 3f;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * maxDistance, Color.red);
        touched = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theObject, maxDistance);

        if (touched == true)
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

        Debug.Log(objTag);

        if (touched == true)
        // if raycast hits, then it checks if it hit an object with the tag Door.
        {
            if (theObject.collider.tag == "Drawer")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();


                //This will set the bool the opposite of what it is.
                drawerOpened = !drawerOpened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("drawerOpened", !drawerOpened);
            }



            if (theObject.collider.tag == "Door")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                doorOpened = !doorOpened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("doorOpened", !doorOpened);
            }

            if (theObject.collider.tag == "Drawer1")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();


                //This will set the bool the opposite of what it is.
                drawer1Opened = !drawer1Opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("drawer1Opened", !drawer1Opened);
            }

            if (theObject.collider.tag == "Drawer2")
            {

                Debug.Log(drawer2Opened);

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                drawer2Opened = !drawer2Opened;

                Debug.Log(drawer2Opened);

                //This line will set the bool true so it will play the animation.
                anim.SetBool("drawer2Opened", !drawer2Opened);
            }
            if (theObject.collider.tag == "FridgeUp")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                fridgeUpOpened = !fridgeUpOpened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("fridgeUpOpened", !fridgeUpOpened);
            }
            if (theObject.collider.tag == "FridgeDown")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                fridgeDownOpened = !fridgeDownOpened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("fridgeDownOpened", !fridgeDownOpened);
            }
            if (theObject.collider.tag == "Cabin1")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                cabin1Opened = !cabin1Opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("cabin1Opened", !cabin1Opened);
            }
            if (theObject.collider.tag == "Cabin2")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                cabin2Opened = !cabin2Opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("cabin2Opened", !cabin2Opened);
            }
            if (theObject.collider.tag == "Cabin3")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                cabin3Opened = !cabin3Opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("cabin3Opened", !cabin3Opened);
            }
            if (theObject.collider.tag == "Cabin4")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                cabin4Opened = !cabin4Opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("cabin4Opened", !cabin4Opened);
            }
            if (theObject.collider.tag == "Cabin5")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                cabin5Opened = !cabin5Opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("cabin5Opened", !cabin5Opened);
            }
            if (theObject.collider.tag == "Cabin6")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = theObject.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                cabin6Opened = !cabin6Opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("cabin6Opened", !cabin6Opened);
            }
        }
    }
}
