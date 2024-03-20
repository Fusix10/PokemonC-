using System;
using System.Collections;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;

    public static InputManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<InputManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(InputManager).Name;
                    instance = obj.AddComponent<InputManager>();
                }
            }
            return instance;
        }
    }

    private Hashtable keyBindings = new Hashtable();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        InitializeKeyBindings();
    }

    private void InitializeKeyBindings()
    {
        // Ajoutez les touches et leurs fonctions associées ici
        AddKeyBinding(KeyCode.UpArrow, OnUpPressed);
        AddKeyBinding(KeyCode.DownArrow, OnDownPressed);
        AddKeyBinding(KeyCode.LeftArrow, OnLeftPressed);
        AddKeyBinding(KeyCode.RightArrow, OnRightPressed);
        AddKeyBinding(KeyCode.A, OnAPressed);
        AddKeyBinding(KeyCode.Z, OnZPressed);
        AddKeyBinding(KeyCode.E, OnEPressed);
        AddKeyBinding(KeyCode.R, OnRPressed);
        AddKeyBinding(KeyCode.Tab, OnTabPressed);
    }

    private void AddKeyBinding(KeyCode keyCode, Action action)
    {
        if (!keyBindings.ContainsKey(keyCode))
        {
            keyBindings.Add(keyCode, action);
        }
        else
        {
            keyBindings[keyCode] = action;
        }
    }

    private void Update()
    {
        foreach (KeyCode keyCode in keyBindings.Keys)
        {
            if (Input.GetKeyDown(keyCode))
            {
                Action action = (Action)keyBindings[keyCode];
                action?.Invoke();
            }
        }
    }

    // Fonctions appelées lorsque les touches sont pressées
    private void OnUpPressed()
    {
        Debug.Log("Up Arrow Pressed");
    }

    private void OnDownPressed()
    {
        Debug.Log("Down Arrow Pressed");
    }

    private void OnLeftPressed()
    {
        Debug.Log("Left Arrow Pressed");
    }

    private void OnRightPressed()
    {
        Debug.Log("Right Arrow Pressed");
    }

    private void OnAPressed()
    {
        Debug.Log("A Pressed");
    }

    private void OnZPressed()
    {
        Debug.Log("Z Pressed");
    }

    private void OnEPressed()
    {
        Debug.Log("E Pressed");
    }

    private void OnRPressed()
    {
        Debug.Log("R Pressed");
    }

    private void OnTabPressed()
    {
        Debug.Log("Tab Pressed");
    }
}
