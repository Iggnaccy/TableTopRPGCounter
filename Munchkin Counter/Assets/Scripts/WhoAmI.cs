using UnityEngine;
using System.Collections;

public class WhoAmI : MonoBehaviour
{
    public int num;

    public void ChangeActive()
    {
        GameObject.FindGameObjectWithTag("PlayerCreator").GetComponent<PlayerCreator>().ChangeActive(num);
    }
}
