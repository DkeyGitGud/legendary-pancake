using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour
{
    [SerializeField]
    private Text healthText;

    [SerializeField]
    private Text speedText;

    [SerializeField]
    private int healthAddAmount1 = 15;
    [SerializeField]
    private int healthAddAmount3 = 25;
    [SerializeField]
    private int healthAddAmount5 = 40;

    [SerializeField]
    private int movementAddAmount2 = 1;
    [SerializeField]
    private int movementAddAmount4 = 2;

    [SerializeField]
    private int upgradeCost1 = 10;
    [SerializeField]
    private int upgradeCost2 = 20;
    [SerializeField]
    private int upgradeCost3 = 30;
    [SerializeField]
    private int upgradeCost4 = 40;
    [SerializeField]
    private int upgradeCost5 = 50;

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

    public void UpgradeHealth1()
    {
        if(GameMaster.Money < upgradeCost1)
        {
            AudioManager.instance.PlaySound("NoMoney");
            return;
        }

        stats.maxHealth = stats.maxHealth + healthAddAmount1;

        GameMaster.Money -= upgradeCost1;
        AudioManager.instance.PlaySound("Money");

        UpdateValues();
    }

    public void UpgradeSpeed2()
    {
        if (GameMaster.Money < upgradeCost2)
        {
            AudioManager.instance.PlaySound("NoMoney");
            return;
        }

        stats.movementSpeed = stats.movementSpeed + movementAddAmount2;

        GameMaster.Money -= upgradeCost2;
        AudioManager.instance.PlaySound("Money");

        UpdateValues();
    }

    public void UpgradeHealth3()
    {
        if (GameMaster.Money < upgradeCost3)
        {
            AudioManager.instance.PlaySound("NoMoney");
            return;
        }

        stats.maxHealth = stats.maxHealth + healthAddAmount3;

        GameMaster.Money -= upgradeCost3;
        AudioManager.instance.PlaySound("Money");

        UpdateValues();
    }

    public void UpgradeSpeed4()
    {
        if (GameMaster.Money < upgradeCost4)
        {
            AudioManager.instance.PlaySound("NoMoney");
            return;
        }

        stats.movementSpeed = stats.movementSpeed + movementAddAmount4;

        GameMaster.Money -= upgradeCost4;
        AudioManager.instance.PlaySound("Money");

        UpdateValues();
    }

    public void UpgradeHealth5()
    {
        if (GameMaster.Money < upgradeCost5)
        {
            AudioManager.instance.PlaySound("NoMoney");
            return;
        }

        stats.maxHealth = stats.maxHealth + healthAddAmount5;

        GameMaster.Money -= upgradeCost5;
        AudioManager.instance.PlaySound("Money");

        UpdateValues();
    }
}
