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
    
    void Start()
    {
        Debug.Log(Player.Instance.PlayersLife);
        
        Debug.Log(Player.Instance.PlayerImage);
        DisplayText();
    }

    void DisplayText()
    {
        // TODO replace with await function
        while (texts.Count != 0)
        {
            _currentText = texts[_correctTextIndex];
            textMeshPro.text = _currentText.GetText();
            return;
        }
    }
    
    public void OnClickNextText()
    {
        if (_correctTextIndex < texts.Count - 1)
        {
            Debug.Log("true");
            _correctTextIndex++;
            DisplayText();
        }
        else
        {
            Debug.Log("Called");
            SceneHandler.LoadNextScene();
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
}
