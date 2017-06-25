using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class Login : MonoBehaviour
{
    public string titleID;
    public string customID;

    public GameObject startGameWindow;

    private string wordsOne;
    private string wordsTwo;
    
    void Start ()
    {
        // Login to playfab
        PlayFabClientAPI.LoginWithCustomID(new LoginWithCustomIDRequest
        {
            TitleId = titleID,
            CustomId = customID,
            CreateAccount = true
        }, LoginCallback, PlayfabError, null);
	}

    void LoginCallback (LoginResult result)
    {
        Debug.Log("Logged: " + result.PlayFabId);

        // Load words
        PlayFabClientAPI.GetSharedGroupData(new GetSharedGroupDataRequest
        {
            SharedGroupId = "Words"
        }, LoadedWords, PlayfabError, null);
    }

    void LoadedWords (GetSharedGroupDataResult result)
    {
        // Get the Json data from playfab
        // There are a total of 100 words, but since playfab do not allow a big amount of data in just one field, we split in two 50 / 50
        wordsOne = result.Data["0"].Value;
        wordsTwo = result.Data["1"].Value;

        // Parce the Json data
        JSONObject jsonWords1 = new JSONObject(wordsOne);
        JSONObject jsonWords2 = new JSONObject(wordsTwo);

        // First amount of 50 words
        for (int i = 0; i < jsonWords1.keys.Count; i++)
        {
            Game.words.Add(jsonWords1.GetField("" + i + "").str);
        }

        // Second amount of 50 words
        for (int i = 0; i < jsonWords2.keys.Count; i++)
        {
            Game.words.Add(jsonWords1.GetField("" + i + "").str);
        }

        // This is only to display the words on the inspector, no really needed
        Game.Instance.ShowWords();

        // Now we can start the game
        startGameWindow.SetActive(true);
    }

    void PlayfabError (PlayFabError error)
    {
        Debug.LogError(error.ErrorMessage);
    }
}
