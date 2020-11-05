using System;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject uIObj;
    public GameObject player;

    public void Start()
    {
        uIObj.SetActive(false);
        player = GameObject.Find("VR Rig");
        //this function finds the user and sets it as player object
    }

    public void OnTriggerEnter(Collider other)
    {
        if (player = other.gameObject)
        {
            uIObj.SetActive(true);
            //this function opens the UI when player enters triggered area
        }
    }
}
