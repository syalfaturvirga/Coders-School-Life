using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountAndOpenTheDoor : MonoBehaviour
{
    private int items;

    private int collected = 0;

    private bool isTheDoorOpened = false;

    private string tagging = "Collected";

    public Text text;

    public AudioSource suaraCoin;
    /* private float smoothSpeed = 0.125f;
    private Transform leftDoor;
    private Transform rightDoor;

    public Vector3 location = new Vector3(0, 0, 0); */

    void Awake()
    {
        items = GameObject.FindGameObjectsWithTag(tagging).Length;
        Debug.Log(items);
        setText();
        /* leftDoor = GameObject.Find("moving door").transform;
        rightDoor = GameObject.Find("RightOpen").transform; */
    }

    void setText()
    {
        if (text) {
            text.text = collected + "/" + items;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == tagging)
        {
            CountUpAndOpen(other);
            suaraCoin.Play();
        }

        if (other.gameObject.name == "FinishLine" && isTheDoorOpened)
        {
            Debug.Log("Finished ges!");
            ChangeScene();
        }
    }

    private void CountUpAndOpen(Collision collided)
    {
        Destroy(collided.gameObject);
        
        collected++;

        setText();

        if (collected == items && ! isTheDoorOpened)
        {
            OpenTheDoor();
        }
    }

    void ChangeScene()
    {
        string nextScene = "";

        switch (SceneManager.GetActiveScene().name)
        {
            case "Level1":
                nextScene = "Level2";
                break;
            case "Level2":
                nextScene = "Level3";
                break;
            default:
                nextScene = "Credit";
                break;
        }

        SceneManager.LoadScene(nextScene);
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