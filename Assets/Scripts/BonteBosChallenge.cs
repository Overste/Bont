using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BonteBosChallenge : MonoBehaviour
{
   [Header("Text")]
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private List<TextSO> texts = new List<TextSO>();
    [SerializeField] private TextSO positiveText;
    [SerializeField] private TextSO negativeText;
    private TextSO _currentText;
    private int _correctTextIndex;

    [Header("Buttons")]    
    [SerializeField] private Button nextButton;
    [SerializeField] private Button previousButton;
    private List<Button> buttons = new List<Button>();


    [Header("Image")] 
    [SerializeField] private Image backgroundImage;
    [SerializeField] private Image orkImage;
    [SerializeField] private Image playerImage;
    private Color defaultColor = new Color(1f, 1f, 1f, 1f);
    private Color negativeColor = new Color(0.3f, 0.3f, 0.3f, 1f);
    
    void Start()
    {
        GameObject[] btn = GameObject.FindGameObjectsWithTag("BaseButton");

        // Iterate through the array of 'btn' and add them to the 'buttons' list
        for (int i = 0; i < btn.Length; i++)
        {
            buttons.Add(btn[i].GetComponent<Button>());
            buttons[i].gameObject.SetActive(false);
            
            string text = buttons[i].GetComponentInChildren<TextMeshProUGUI>().text;
            buttons[i].onClick.AddListener(() => SetEmotionalState(text));
        }
        
        orkImage.color = negativeColor;
        DisplayText();
    }
    
    void DisplayText()
    {
        _currentText = texts[_correctTextIndex];
        textMeshPro.text = _currentText.GetText();
    }

    public void OnClickNextText()
    {
        if (_correctTextIndex < texts.Count - 1)
        {
            _correctTextIndex++;
            DisplayText();
        }
        
        if (_correctTextIndex == texts.Count - 1)
        {
            MakeButtonsActive();
        }
    }

    public void OnClickPreviousText()
    {
        if (_correctTextIndex > 0)
        {
            _correctTextIndex--;
            DisplayText();
        }
    }

    public void SetEmotionalState(string text)
    {
        if (text.Split(' ').Last() == "BLIJ" || text.Split(' ').Last() == "LIEFDEVOL")
        {
            orkImage.color = defaultColor;
            playerImage.color = defaultColor;
            textMeshPro.text = positiveText.GetText();
        }
        else
        {
            orkImage.color = negativeColor;
            playerImage.color = negativeColor;
            textMeshPro.text = negativeText.GetText();
        }
    }
    
    // Example function making all of the buttons, non-interactable
    private void MakeButtonsActive()
    {
        // Iterate through each button in the 'buttons' list & set interactable to false
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
}
