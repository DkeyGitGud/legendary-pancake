using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour
{
    [SerializeField]
    private Text healthText;

    [SerializeField]
    private Text speedText;

    [SerializeField]
    private float healthMultiplier = 1.3f;

    [SerializeField]
    private float movementMultiplier = 1.2f;

    private PlayerStats stats;

    private void OnEnable()
    {
        stats = PlayerStats.instance;
        UpdateValues();
    }

    void UpdateValues()
    {
        healthText.text = "HEALTH: " + stats.maxHealth;
        speedText.text = "SPEED: " + stats.movementSpeed;
    }

    public void UpgradeHealth()
    {
        stats.maxHealth = (int)(stats.maxHealth * healthMultiplier);
        UpdateValues();
    }

    public void UpgradeSpeed()
    {
        stats.movementSpeed = Mathf.Round(stats.movementSpeed * movementMultiplier);
        UpdateValues();
    }
}
