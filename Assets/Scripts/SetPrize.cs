using TMPro;
using UnityEngine;

public class SetPrize : MonoBehaviour
{
    public string prizeName;
    public TextMeshPro textMeshPro;

    private void Awake() 
    {
        if (!textMeshPro) 
        {
            GameObject go = this.transform.GetChild(0).gameObject;
            textMeshPro = go.GetComponent<TextMeshPro>();
        }
        textMeshPro.text = prizeName;
    }
}