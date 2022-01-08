using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text property", fileName = "new text")]
public class TextSO : ScriptableObject
{
    [TextArea(2, 6)] [SerializeField] private string text;

    public string GetText()
    {
        return text;
    }
}
