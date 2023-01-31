using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI stickText;

    // Start is called before the first frame update
    void Start()
    {
        stickText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateStickText(PlayerInventory playerInventory)
    {
        stickText.text = playerInventory.NumberOfSticks.ToString();
    }
}
