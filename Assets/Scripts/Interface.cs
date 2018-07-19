using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour {

    public Color[] _color; // 0 - белый, 1 - оранжевый
    public GameObject[] _menuPanel; // по порядку от главной до настроек

    private void Start()
    {
        _menuPanel[0].GetComponent<Image>().color = _color[1]; // по дефолту активна главная
    }

    public void Menu(int id)
    {
        for(int i = 0; i <_menuPanel.Length; i++){
            _menuPanel[i].GetComponent<Image>().color = _color[0]; // Ставим всем белый цвет
        }
        _menuPanel[id].GetComponent<Image>().color = _color[1];
    }

}
