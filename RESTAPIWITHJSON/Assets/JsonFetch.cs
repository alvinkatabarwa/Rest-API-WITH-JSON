using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class JsonFetch : MonoBehaviour
{
    private string apiUrl = "https://api.jsonbin.io/v3/b/6686a992e41b4d34e40d06fa";

    void Start()
    {
        StartCoroutine(GetJsonData());
    }

    IEnumerator GetJsonData()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string json = request.downloadHandler.text;
                Debug.Log("JSON Received: " + json);

                // Deserialize JSON using JsonUtility
                RootObject root = JsonUtility.FromJson<RootObject>(json);
                UIManager.Instance.DisplayData(root.record);
            }
            else
            {
                Debug.LogError("Could not get the JSON: " + request.error);
            }
        }
    }
}
