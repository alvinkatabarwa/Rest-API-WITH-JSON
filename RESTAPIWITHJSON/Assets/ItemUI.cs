using UnityEngine;
using TMPro;

public class ItemUI : MonoBehaviour
{
    public TMP_Text playerNameText;
    public TMP_Text levelText;
    public TMP_Text healthText;
    public TMP_Text positionText;

    public void Setup(PlayerData data)
    {
        playerNameText.text = data.playerName;
        levelText.text = "Level: " + data.level.ToString();
        healthText.text = "Health: " + data.health.ToString();
        positionText.text = "Position: " + data.position.x + ", " + data.position.y + ", " + data.position.z;
    }
}
