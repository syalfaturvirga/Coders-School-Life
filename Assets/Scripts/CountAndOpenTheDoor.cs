using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountAndOpenTheDoor : MonoBehaviour
{
    private int items;

    private int collected = 0;

    private bool isTheDoorOpened = false;

    private string tagging = "Collected";
    /* private float smoothSpeed = 0.125f;
    private Transform leftDoor;
    private Transform rightDoor;

    public Vector3 location = new Vector3(0, 0, 0); */

    void Awake()
    {
        items = GameObject.FindGameObjectsWithTag(tagging).Length;
        Debug.Log(items);
        /* leftDoor = GameObject.Find("moving door").transform;
        rightDoor = GameObject.Find("RightOpen").transform; */
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == tagging)
        {
            // kudune mbuka modal sek se
            CountUpAndOpen(other);
        }

        if (other.gameObject.name == "FinishLine" && isTheDoorOpened)
        {
            Debug.Log("Finished ges!");
        }
    }

    private void CountUpAndOpen(Collision collided)
    {
        Destroy(collided.gameObject);
        
        collected++;

        if (collected == items && ! isTheDoorOpened)
        {
            OpenTheDoor();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // open the door to freedom!
    void OpenTheDoor()
    {
        Debug.Log("The door is destroyed");
        /* Vector3 desiredPosition = leftDoor.position + leftDoor.rotation * location;
        Vector3 smoothedPosition = Vector3.Lerp(leftDoor.position, desiredPosition, smoothSpeed);
        leftDoor.position = smoothedPosition; */
        // GameObject.Find("Opened").transform.position += new Vector3(0, 0, -5);
        // Debug.Log(desiredPosition);

        // leftDoor.transform = null;
        isTheDoorOpened = true;
        Destroy(GameObject.Find("Opened"));
    }
}