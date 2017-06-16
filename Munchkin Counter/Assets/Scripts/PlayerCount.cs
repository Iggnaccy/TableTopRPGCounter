using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PlayerCount : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }
    
    public void AddPlayer()
    {
        PlayerList.playerCount++;
        text.text = PlayerList.playerCount.ToString();
    }

    public void RemovePlayer()
    {
        if (PlayerList.playerCount > 2)
        {
            PlayerList.playerCount--;
            text.text = PlayerList.playerCount.ToString();
        }
    }
}
