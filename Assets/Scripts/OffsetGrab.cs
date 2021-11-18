using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OffsetGrab : XRGrabInteractable
{
    private Vector3 interactorPosition = Vector3.zero;
    private Quaternion interactorRotation = Quaternion.identity;

    protected override void OnSelectEntered(SelectEnterEventArgs selectEnterEventArgs)
    {
        base.OnSelectEntered(selectEnterEventArgs);
        StoreInteractor(selectEnterEventArgs.interactor);
        MatchAttachmentPoints(selectEnterEventArgs.interactor);
    }

    private void StoreInteractor(XRBaseInteractor interactor)
    {
        interactorPosition = interactor.attachTransform.localPosition;
        interactorRotation = interactor.attachTransform.localRotation;
    }

    private void MatchAttachmentPoints(XRBaseInteractor interactor)
    {
        bool hasAttach = attachTransform != null;
        interactor.attachTransform.position = hasAttach ? attachTransform.position : transform.position;   
        interactor.attachTransform.rotation = hasAttach ? attachTransform.rotation : transform.rotation;   
    }
    protected override void OnSelectExited(SelectExitEventArgs selectExitEventArgs)
    {
        base.OnSelectExited(selectExitEventArgs);
        ResetAttachmentPoints(selectExitEventArgs.interactor);
        ClearInteractor(selectExitEventArgs.interactor);
    }

    private void ResetAttachmentPoints(XRBaseInteractor interactor)
    {
        interactor.attachTransform.localPosition = interactorPosition;
        interactor.attachTransform.localRotation = interactorRotation;
    }

    private void ClearInteractor(XRBaseInteractor interactor)
    {
        interactorPosition = Vector3.zero;
        interactorRotation = Quaternion.identity;
    }
}
