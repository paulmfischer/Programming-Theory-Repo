using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nameText;
    
    public void LoadAnimalScene()
    {
        GameData.Instance.userName = nameText.text;
        SceneManager.LoadScene("Animals");
    }
}
