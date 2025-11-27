using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordImageManager : MonoBehaviour
{
    [System.Serializable]
    public class WordImagePair
    {
        public string word;
        public Texture2D image;
    }

    public WordImagePair[] pairs;
    public RawImage imageDisplay;
    public TextMeshProUGUI wordDisplay;

    private int currentIndex = 0;
    private bool showingWord = true;

    void Start()
    {
        ShowWord();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (showingWord)
            {
                ShowImage(); 
            }
            else
            {
                currentIndex = (currentIndex + 1) % pairs.Length;
                ShowWord(); 
            }
        }
    }

    void ShowWord()
    {
        wordDisplay.text = pairs[currentIndex].word;
        imageDisplay.enabled = false;          
        showingWord = true;
    }

    void ShowImage()
    {
        wordDisplay.text = "";
        imageDisplay.texture = pairs[currentIndex].image;
        imageDisplay.enabled = true;
        showingWord = false;
    }
}
