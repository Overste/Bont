using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button nextButton;
    [SerializeField] private Button previousButton;
    [SerializeField] private Button startButton;
    
    [Header("Images")]
    [SerializeField] private List<Sprite> characters = new List<Sprite>();
    [SerializeField] private Image character;
    private int characterIndex = 0;
    
    void Start()
    {
        // Debug.Log(characters[characterIndex].get);
        
        
        character.sprite = characters[characterIndex];
        Debug.Log(AssetDatabase.GetAssetPath(character.sprite));        // player = Player.Instance;
    }

    public void OnClickNextCharacter()
    {
        if (characters.Count - 1 < ++characterIndex)
        {
            characterIndex = 0;
        }
        
        character.sprite = characters[characterIndex];
    }

    public void OnCLickPreviousCharacter()
    {
        if (0 > --characterIndex)
        {
            characterIndex = 2;
        }
        
        character.sprite = characters[characterIndex];
    }

    public void StartGame()
    {
        GameManager.Instance.PlayerImagePath = AssetDatabase.GetAssetPath(character.sprite);
        GameManager.Instance.PlayersLife = 3;
        GameManager.Instance.PlayerSprite = character.sprite;
        Debug.Log(GameManager.Instance);
        Debug.Log(GameManager.Instance.PlayerImagePath);
        SceneHandler.LoadNextScene();
    }
}
