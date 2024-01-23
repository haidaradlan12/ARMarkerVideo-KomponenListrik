using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class VideoManager : MonoBehaviour
{
    public RectTransform PVideo;
    // Start is called before the first frame update
    void Start()
    {
        PVideo.DOAnchorPos(new Vector2(0, 2000), 1.0f);
    }
    public void VHide()
    {
        PVideo.DOAnchorPos(new Vector2(0, 2000), 1.0f);
    }
    public void VUnhide()
    {
        PVideo.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
