using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HandleClicks : MonoBehaviour, IPointerClickHandler {

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
    }
	
}
