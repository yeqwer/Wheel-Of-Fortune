using TMPro;
using UnityEngine;

public class CheckPrize : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    public string basePrizeText;
    public string yourPrize;

    private void Awake() 
    {
        yourPrize = basePrizeText;
    }

    private void Update() 
    {
        textUI.text = yourPrize;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Checker")) 
        {
            SetPrize prize = other.GetComponent<SetPrize>();
            yourPrize = basePrizeText + prize.prizeName;
        }
    }
}
