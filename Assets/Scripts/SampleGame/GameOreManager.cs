using TMPro;
using UnityEngine;

public class GameOreManager : MonoBehaviour
{
    public static GameOreManager instance { get; private set; }

    public int totalOresMined = 0;
    public TextMeshProUGUI oresMinedText;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        oresMinedText.text = totalOresMined.ToString();
    }

    public void AddOresMined(int amount)
    {
        totalOresMined += amount;
        oresMinedText.text = totalOresMined.ToString();
    }
}
