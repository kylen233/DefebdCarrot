using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewTest : MonoBehaviour
{

    private ScrollRect _scrollRect;
   
	void Start ()
	{
        _scrollRect = GetComponent<ScrollRect>();
        _scrollRect.onValueChanged.AddListener(OnValueChange);
     //   Debug.Log("world pos:" + _scrollRect.content.position);
     //   Debug.Log("local pos:" + _scrollRect.content.localPosition);


     //   Debug.Log("width:" + (_scrollRect.content.rect.width));

     //   _scrollRect.content.rect.Set(0, 0, 720, 100);
     //   Debug.Log("x:" + (_scrollRect.content.rect.x));
     //   Debug.Log("y:" + _scrollRect.content.rect.y);
     //   _scrollRect.content.sizeDelta=new Vector2(208,182.6f);
     //   Debug.Log(_scrollRect.content.sizeDelta.x);
   
     //   Debug.Log(_scrollRect.content.sizeDelta.y);
	    //_scrollRect.horizontalNormalizedPosition = 1;
	}

    private void OnValueChange(Vector2 vector2)
    {
        Debug.Log(vector2);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
