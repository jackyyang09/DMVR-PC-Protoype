using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public enum DuelViewEnum
{
    Start,
    Disk
}

public static class DuelViewEnumExtensions
{
    public static int ToInt(this DuelViewEnum e)
    {
        return (int)e;
    }
}

public class DuelViewController : BasicSingleton<DuelViewController>
{
    [SerializeField] InputActionReference forwardAction;
    [SerializeField] InputActionReference backAction;
    [SerializeField] CinemachineVirtualCamera[] cameras;
    [SerializeField] Animator anim;

    public DuelViewState CurrentState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnEnable() 
    {
        forwardAction.action.performed += OnForward;
        backAction.action.performed += OnBack;
    }

    private void OnDisable() 
    {
        forwardAction.action.performed -= OnForward; 
        backAction.action.performed -= OnBack; 
    }

    public void ShowCameraAtEnum(DuelViewEnum state)
    {
        cameras[state.ToInt()].enabled = true;
    }

    public void HideCameraAtEnum(DuelViewEnum state)
    {
        cameras[state.ToInt()].enabled = false;
    }

    private void OnForward(InputAction.CallbackContext context)
    {
        Debug.Log("Forward");
        anim.SetTrigger("Forward");
    }

    private void OnBack(InputAction.CallbackContext context)
    {
        Debug.Log("Back");
        anim.SetTrigger("Back");
    }
}
