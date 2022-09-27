using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks //photon will call automatically a callback function
{
    public TMP_InputField userNameInput;
    public TextMeshProUGUI buttonText;

    public void OnClickConnect() //connects u to the server
    {
        if (userNameInput.text.Length >= 1) //input cannot be empty
        {
            PhotonNetwork.NickName = userNameInput.text; //hands to photon ur username
            buttonText.text = "Connecting..."; //changes text while user is connecting
            PhotonNetwork.ConnectUsingSettings(); //connects user to the server
        }
    }

    public override void OnConnectedToMaster() //called automatically by puncallbacks
    {
        SceneManager.LoadScene("Lobby");
    }
}
