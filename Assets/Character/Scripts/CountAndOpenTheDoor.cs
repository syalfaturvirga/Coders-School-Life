using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountAndOpenTheDoor : MonoBehaviour
{
    private int items = 5;

    private int collected = 5;

    private bool isTheDoorOpened = false;
    private float smoothSpeed = 0.125f;
    private Transform leftDoor = GameObject.Find("LeftOpen").transform;
    private Transform rightDoor = GameObject.Find("RightOpen").transform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collected == items && !isTheDoorOpened) {
            OpenTheDoor();
        }
    }

    // open the door to freedom!
    void OpenTheDoor()
    {
        // leftDoor.transform = null;
        isTheDoorOpened = true;
    }
}
