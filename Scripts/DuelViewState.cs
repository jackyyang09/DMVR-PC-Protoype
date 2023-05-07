using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DuelViewState : StateMachineBehaviour
{
    [SerializeField] DuelViewEnum viewEnum;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        DuelViewController.Instance.ShowCameraAtEnum(viewEnum);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
        DuelViewController.Instance.HideCameraAtEnum(viewEnum);
    }
}