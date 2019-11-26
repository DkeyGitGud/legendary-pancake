using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsToBuyScript : MonoBehaviour
{
    [System.Serializable]
    public class IdeaToChooseFrom
    {
        public string name;
        public Sprite image;
    }

    [System.Serializable]
    public class Idea
    {
        public Text name;
        public Image image;
    }

    public IdeaToChooseFrom[] ideasRandomPropositions;

    public Idea[] ideasPicked;

    List<int> listNumbers = new List<int>();

    int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < ideasPicked.Length; i++)
        {
            do
            {
                randomNumber = Random.Range(0, ideasRandomPropositions.Length);
                ideasPicked[i].name.text = ideasRandomPropositions[randomNumber].name;
                ideasPicked[i].image.sprite = ideasRandomPropositions[randomNumber].image;
            } while (listNumbers.Contains(randomNumber));

            listNumbers.Add(randomNumber);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
