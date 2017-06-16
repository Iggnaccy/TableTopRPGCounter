using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AssignName : MonoBehaviour
{
    public int playerNumber = 1;
    public Text playerString;
    public Text playerName;

    public void Assign()
    {
        PlayerList.CreatePlayer(playerName.text);
        playerName.text = "";
        playerNumber++;
        if(playerNumber > PlayerList.playerCount)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Counter");
        }
        playerString.text = "Player " + playerNumber.ToString();
    }
}
