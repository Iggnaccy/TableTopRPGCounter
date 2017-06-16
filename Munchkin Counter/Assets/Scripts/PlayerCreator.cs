using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerCreator : MonoBehaviour
{

    public GameObject list;
    public GameObject playerButton;
    public List<GameObject> playerDisplays;
    public Text activePlayerName;
    public Text activePlayerLevel;
    public Text activePlayerPower;
    public Text activePlayerSum;
    public GameObject activePlayerStats;

    void Start ()
    {
        for (int i = 0; i < PlayerList.playerCount; i++)
        {
            GameObject temp = Instantiate(playerButton, list.transform) as GameObject;
            Debug.Log("Stworzyłem obiekt, " + temp.transform.ToString());
            temp.transform.localPosition = new Vector3(20, -20 - 210 * i, 0);
            temp.GetComponentsInChildren<Text>()[0].text = PlayerList.names[i];
            temp.GetComponent<WhoAmI>().num = i;
            playerDisplays.Add(temp);
        }
	}
	
	void Update ()
    {
	
	}

    public void ChangeLevel(int x)
    {
        PlayerList.level[PlayerList.activePlayer] += x;
        if (PlayerList.level[PlayerList.activePlayer] < 1)
        {
            PlayerList.level[PlayerList.activePlayer] = 1;
        }
        playerDisplays[PlayerList.activePlayer].GetComponentsInChildren<Text>()[4].text = PlayerList.level[PlayerList.activePlayer].ToString();
        playerDisplays[PlayerList.activePlayer].GetComponentsInChildren<Text>()[6].text = (PlayerList.power[PlayerList.activePlayer] + PlayerList.level[PlayerList.activePlayer]).ToString();
        activePlayerLevel.text = PlayerList.level[PlayerList.activePlayer].ToString();
        activePlayerPower.text = PlayerList.power[PlayerList.activePlayer].ToString();
        activePlayerSum.text = (PlayerList.level[PlayerList.activePlayer] + PlayerList.power[PlayerList.activePlayer]).ToString();
    }

    public void ChangeBonus(int x)
    {
        PlayerList.power[PlayerList.activePlayer] += x;
        if(PlayerList.power[PlayerList.activePlayer] < 0)
        {
            PlayerList.power[PlayerList.activePlayer] = 0;
        }
        playerDisplays[PlayerList.activePlayer].GetComponentsInChildren<Text>()[5].text = PlayerList.power[PlayerList.activePlayer].ToString();
        playerDisplays[PlayerList.activePlayer].GetComponentsInChildren<Text>()[6].text = (PlayerList.power[PlayerList.activePlayer] + PlayerList.level[PlayerList.activePlayer]).ToString();
        activePlayerLevel.text = PlayerList.level[PlayerList.activePlayer].ToString();
        activePlayerPower.text = PlayerList.power[PlayerList.activePlayer].ToString();
        activePlayerSum.text = (PlayerList.level[PlayerList.activePlayer] + PlayerList.power[PlayerList.activePlayer]).ToString();
    }

    public void ChangeActive(int x)
    {
        activePlayerStats.SetActive(true);
        PlayerList.activePlayer = x;
        activePlayerName.text = PlayerList.names[PlayerList.activePlayer];
        activePlayerLevel.text = PlayerList.level[PlayerList.activePlayer].ToString();
        activePlayerPower.text = PlayerList.power[PlayerList.activePlayer].ToString();
        activePlayerSum.text = (PlayerList.level[PlayerList.activePlayer] + PlayerList.power[PlayerList.activePlayer]).ToString();
    }
}
