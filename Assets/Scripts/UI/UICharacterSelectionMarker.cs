using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UICharacterSelectionMarker : MonoBehaviour
{
    [SerializeField] private Image markerImage;
    [SerializeField] private Image lockImage;

    private UICharacterSelectionMenu menu;
    private bool initializing;
    private bool initialized;

    private void Awake()
    {
        menu = GetComponentInParent<UICharacterSelectionMenu>();
        markerImage.gameObject.SetActive(false);
        lockImage.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (!initializing)
            StartCoroutine(Initialize());

        if (!initialized)
            return;
    }

    private IEnumerator Initialize()
    {
        initializing = true;
        yield return new WaitForSeconds(0.5f);
        markerImage.gameObject.SetActive(true);
        initialized = true;
    }
}
