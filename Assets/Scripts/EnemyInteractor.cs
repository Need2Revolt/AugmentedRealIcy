using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyInteractor : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private MeshRenderer m_MeshRender;

    public GameObject self;

    void Awake () {
        //do i need this?
        //m_MeshRender = transform.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        //Nothing?
        //transform.rotation = NRInput.GetRotation();
    }

    //when pointer click, set the cube color to random color
    public void OnPointerClick(PointerEventData eventData)
    {
        //m_MeshRender.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        Destroy(self, 0);
    }

    //when pointer hover, set the cube color to green
    public void OnPointerEnter(PointerEventData eventData)
    {
        //show enemy health?
    }

    //when pointer exit hover, set the cube color to white
    public void OnPointerExit(PointerEventData eventData)
    {
        //hide enemy health?
    }

}
