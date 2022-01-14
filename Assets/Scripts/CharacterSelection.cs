using System.Collections;
using System.Collections.Generic;
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

    // private Player player;
    
    void Start()
    {
        // player = Player.Instance;
        character.sprite = characters[characterIndex];
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
        Player.Instance.PlayerImage = character;
        Player.Instance.PlayersLife = 1;
        SceneHandler.LoadNextScene();
    }
}
