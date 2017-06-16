using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DebugPlayerName : MonoBehaviour
{
    Text myText;
    public GameObject confButton;

    void Start()
    {
        myText = GetComponent<Text>();
    }

	void Update ()
    {
        if(confButton.GetComponent<AssignName>().playerNumber > 1)
            myText.text = PlayerList.names.ToArray()[confButton.GetComponent<AssignName>().playerNumber - 1];
	}
}
