using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class PlayerInventory : MonoBehaviour
{
    public int NumberOfSticks { get; private set; }

    public UnityEvent<PlayerInventory> OnStickCollected;

    public void StickCollected()
    {
        NumberOfSticks++;
        OnStickCollected.Invoke(this);
        if(NumberOfSticks == 20)
        {
            SceneManager.LoadScene("Epilogue");
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}