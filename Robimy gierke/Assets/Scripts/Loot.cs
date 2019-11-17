using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public Transform loot;

    private AudioManager audioManager;

    private void Start()
    {
        //caching
        audioManager = AudioManager.instance;
        if (audioManager == null)
        {
            Debug.LogError("FREAK OUT! No AudioManager found in the scene.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player _player = collision.collider.GetComponent<Player>();
        if (_player != null)
        {
            Destroy(loot.gameObject);

            // Gain some money
            GameMaster.Money += (int)(Random.Range(0.5f,1f)*10);

            audioManager.PlaySound("Money");
        }
    }
}
