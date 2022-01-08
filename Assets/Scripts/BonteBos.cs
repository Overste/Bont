using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BonteBos : MonoBehaviour
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
    [FormerlySerializedAs("PositiveButton")] [SerializeField] private Button positiveButton;
    [SerializeField] private Button negativeButton;

    [Header("Image")] 
    [SerializeField] private Image backgroundImage;
    [FormerlySerializedAs("goblinImage")] [SerializeField] private Image enemyImage;
    [SerializeField] private Image playerImage;
    private Color defaultColor = new Color(1f, 1f, 1f, 1f);
    private Color negativeColor = new Color(0.3f, 0.3f, 0.3f, 1f);
    
    void Start()
    {
        enemyImage.color = negativeColor;
        positiveButton.gameObject.SetActive(false);
        negativeButton.gameObject.SetActive(false);
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
            positiveButton.gameObject.SetActive(true);
            negativeButton.gameObject.SetActive(true);
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

    public void OnClickPositive()
    {
        enemyImage.color = defaultColor;
        textMeshPro.text = positiveText.GetText();
        negativeButton.interactable = false;
    }
    
    public void OnClickNegative()
    {
        playerImage.color = negativeColor;
        // backgroundImage.color = negativeColor;
        textMeshPro.text = negativeText.GetText();
        positiveButton.interactable = false;

    }
}
