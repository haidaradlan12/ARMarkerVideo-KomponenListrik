using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public GameObject Back1, Back2, Back3;
    public RectTransform PUtama, PPetunjuk, PTentang;


    // Start is called before the first frame update
    void Start()
    {
        Back1.SetActive(true);
        Back2.SetActive(false);
        Back3.SetActive(false);
        PUtama.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PPetunjuk.DOAnchorPos(new Vector2(5000, 0), 1.0f);
        PTentang.DOAnchorPos(new Vector2(5000, 0), 1.0f);
    }
    public void ButtonKembali()
    {
        Back1.SetActive(true);
        Back2.SetActive(false);
        Back3.SetActive(false);
        PUtama.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PPetunjuk.DOAnchorPos(new Vector2(5000, 0), 1.0f);
        PTentang.DOAnchorPos(new Vector2(5000, 0), 1.0f);
    }
    public void ButtonTentang()
    {
        Back1.SetActive(false);
        Back2.SetActive(false);
        Back3.SetActive(true);
        PUtama.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        PPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PTentang.DOAnchorPos(new Vector2(5000, 0), 1.0f);
    }
    public void ButtonPetunjuk()
    {
        Back1.SetActive(false);
        Back2.SetActive(true);
        Back3.SetActive(false);
        PUtama.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        PPetunjuk.DOAnchorPos(new Vector2(5000, 0), 1.0f);
        PTentang.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}