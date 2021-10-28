using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class OculusSetup : MonoBehaviour
{
    public XRController Controller = null;
    private GameObject _camera;
    private CharacterController _charCtrl;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<XRRig>().cameraGameObject;
        _charCtrl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CommonInput();
    }

    private void CommonInput()
    {
        // A Button
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primary)) 
            if(primary)
                Debug.Log("primaryButton"); 
        //output += "A Pressed: " + primary + "\n";

        // B Button
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondary)) 
        if(secondary)
            Debug.Log("secondaryButton");
        // output += "B Pressed: " + secondary + "\n";

        // Touchpad/Joystick touch
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxisTouch, out bool touch))
            if(touch) 
                Debug.Log("primary2DAxisTouch");
        // output += "Touchpad/Joystick Touch: " + touch + "\n";

        // Touchpad/Joystick press
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out bool press))
            if (press)
                Debug.Log("primary2DAxisClick");
        // output += "Touchpad/Joystick Pressed: " + press + "\n";

        // Touchpad/Joystick position
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position)) 
        { 
            Vector3 inputVector = new Vector3(position.x, Physics.gravity.y, z: position.y);
            var inputDirection = transform.TransformDirection(inputVector);  //컨트롤러에서 이동할 방향
            var lookDirection = new Vector3(x:0, _camera.transform.eulerAngles.y, z:0);
            var newDirection = Quaternion.Euler(lookDirection) * inputDirection; //캐릭터가 이동할 방향
            _charCtrl.Move(motion: newDirection * Time.deltaTime * 15);
        }
        // output += "Touchpad/Joystick Position: " + position + "\n";

        // Grip press
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool grip)) if(grip) { Debug.Log("gripButton"); }
        //  output += "Grip Pressed: " + grip + "\n";

        // Grip amount
        //if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.grip, out float gripAmount))  { Debug.Log("grip"); }
        //  output += "Grip Amount: " + gripAmount + "\n";

        // Trigger press
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger)) if(trigger) { Debug.Log("triggerButton"); }
        // output += "Trigger Pressed: " + trigger + "\n";

        // Index/Trigger amount
        //if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerAmount)) { Debug.Log("trigger"); }
          //  output += "Trigger: " + triggerAmount;
    }
}
