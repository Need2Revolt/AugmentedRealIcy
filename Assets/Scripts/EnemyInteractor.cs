using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyInteractor : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject self;

    void Awake () {
        //do i need this?
    }

    void Update()
    {
        //Nothing?
    }

    //when pointer click, enemy has been shot and killed
    public void OnPointerClick(PointerEventData eventData)
    {
        //add enemies that don't die immediately?
        Destroy(self, 0);
    }

    //when pointer hover, not sure what to do
    public void OnPointerEnter(PointerEventData eventData)
    {
        //show enemy health?
    }

    //when pointer exit hover, not sure what to do
    public void OnPointerExit(PointerEventData eventData)
    {
        //hide enemy health?
    }

}
