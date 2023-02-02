using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {

        [Header("Output")]
        public StarterAssetsInputs starterInputs;

        [SerializeField]
        public GameObject OpenButton;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            starterInputs.MoveInput(virtualMoveDirection);
        }

        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            starterInputs.LookInput(virtualLookDirection);
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            starterInputs.JumpInput(virtualJumpState);
        }

        public void VirtualSprintInput(bool virtualSprintState)
        {
           
            starterInputs.SprintInput(virtualSprintState);
        }

        public void VirtualThrowInput(bool virtualThrowState)
        {
            starterInputs.ThrowInput(virtualThrowState);
        }

        public void VirtualTorchInput(bool virtualTorchState)
        {
            starterInputs.TorchInput(virtualTorchState);
        }

        public void VirtualOpenInput(bool virtualOpenState)
        {
            starterInputs.OpenInput(virtualOpenState);
        }

    }

}
