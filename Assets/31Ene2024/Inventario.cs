using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventario : MonoBehaviour
{
    public List<GameObject> prefabs;
    private Vector3 offset;
    private bool estaArrastrando = false;
    public GameObject imagenBasura;

    void OnMouseDown()
    {
        if (prefabs.Count > 0)
        {
            offset = transform.position - Input.mousePosition;
            estaArrastrando = true;
        }
    }

    void OnMouseDrag()
    {
        if (estaArrastrando)
        {
            transform.position = Input.mousePosition + offset;
        }
    }

    //void OnMouseUp()
    //{
    //    estaArrastrando = false;

    //    if (prefabs.Count > 0)
    //    {
    //        GameObject prefabSeleccionado = null;
    //        Transform transformPadre = null;
    //        bool estaDentroArea = false;

    //        // Iteramos sobre cada prefab en la lista
    //        foreach (GameObject prefab in prefabs)
    //        {
    //            // Si el prefab actual est� dentro del �rea, lo seleccionamos
    //            if (prefab.GetComponent<DraggableArea>().estaDentroArea(transform.position))
    //            {
    //                prefabSeleccionado = prefab;
    //                transformPadre = prefab.transform;
    //                estaDentroArea = true;
    //            }
    //        }

    //        // Si hemos encontrado un prefab que est� dentro del �rea, lo asignamos al script PrefabHolder
    //        if (prefabSeleccionado != null)
    //        {
    //            prefabSeleccionado.GetComponent<PrefabHolder>().prefab = this.gameObject;
    //            transform.SetParent(transformPadre);
    //        }
    //        // Si no hay ning�n prefab dentro del �rea y el objeto se ha soltado sobre la imagen de basura, destruimos el objeto
    //        else if (imagenBasura != null && imagenBasura.GetComponent<DraggableArea>().estaDentroArea(transform.position))
    //        {
    //            Destroy(this.gameObject);
    //        }
    //        // Si no hay ning�n prefab dentro del �rea, destruimos el objeto actual
    //        else
    //        {
    //            Destroy(this.gameObject);
    //        }
    //    }
    //}
}