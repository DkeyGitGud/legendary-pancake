using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    AudioManager audioManager;

    private void Start()
    {
        audioManager = AudioManager.instance;
        if (audioManager == null)
        {
            Debug.LogError("No audiomanager found!");
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("WYCHODZIMY DO GRY");

            audioManager.StopSound("CalmMusic");

            audioManager.PlaySound("FightingMusic");

            SceneManager.LoadScene("MainLevel");
        }
    }
}
