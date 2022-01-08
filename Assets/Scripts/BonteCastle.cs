using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BonteCastle : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private List<TextSO> texts = new List<TextSO>();
    private TextSO _currentText;
    private int _correctTextIndex;

    [Header("Buttons")]    
    [SerializeField] private Button nextButton;
    [SerializeField] private Button previousButton;
    // private bool _buttonState;  
    
    void Start()
    {
        DisplayText();
    }


    void GetNextText()
    {
        
    }
    
    void DisplayText()
    {
        Debug.Log(_correctTextIndex);
        Debug.Log(texts);
        _currentText = texts[_correctTextIndex];
        textMeshPro.text = _currentText.GetText();
    }

    void SetButtonState()
    {
        
    }

    public void OnClickNextText()
    {
        if (_correctTextIndex < texts.Count - 1)
        {
            _correctTextIndex++;
            DisplayText();
        }

        Debug.Log("OnClickNextText");
    }

    public void OnClickPreviousText()
    {
        if (_correctTextIndex > 0)
        {
            _correctTextIndex--;
            DisplayText();
        }

        Debug.Log("OnClickPreviousText");
    }
}
