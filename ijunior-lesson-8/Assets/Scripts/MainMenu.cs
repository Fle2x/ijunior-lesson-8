using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] _gamePanels;

    public void ShowPanel(int index)
    {
        _gamePanels[index].SetActive(true);
    }

    public void HidePanel(int index)
    {
        _gamePanels[index].SetActive(false);
    }
}
