// GENERATED AUTOMATICALLY FROM 'Assets/Player1Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player1Actions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1Actions"",
    ""maps"": [
        {
            ""name"": ""Player_Map"",
            ""id"": ""c5f638fa-75af-4b5c-a676-2e87b5539c83"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""44b8d719-47a7-405a-a76f-6fab66a301f2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement2"",
                    ""type"": ""Value"",
                    ""id"": ""3833e028-9f9e-47b5-aabb-3f5520d814a9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""be47394f-3220-4b8a-9796-e1e236e74fde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump2"",
                    ""type"": ""Button"",
                    ""id"": ""ff6260dc-30ac-4cdb-8eb0-5453981fd8b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""0175d745-e01b-406a-8d36-89aadf4edd38"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f7849d3f-2359-440c-9ac9-6a634858fde5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""55b003c4-f32a-4dbf-9425-1db08715a98c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Movement2"",
                    ""id"": ""a43cdbd6-ed5f-490b-975a-206967fc460b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e0ba5f45-ba21-479a-83bc-71d648f9ecb6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3051c53a-b512-4bbf-accc-33b45d15ea8f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c1e4de6f-0cb7-4cae-aad2-0abbb80f6065"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a02d14d-43f7-42bb-bed7-ce3247d57464"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player_Map
        m_Player_Map = asset.FindActionMap("Player_Map", throwIfNotFound: true);
        m_Player_Map_Movement = m_Player_Map.FindAction("Movement", throwIfNotFound: true);
        m_Player_Map_Movement2 = m_Player_Map.FindAction("Movement2", throwIfNotFound: true);
        m_Player_Map_Jump = m_Player_Map.FindAction("Jump", throwIfNotFound: true);
        m_Player_Map_Jump2 = m_Player_Map.FindAction("Jump2", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player_Map
    private readonly InputActionMap m_Player_Map;
    private IPlayer_MapActions m_Player_MapActionsCallbackInterface;
    private readonly InputAction m_Player_Map_Movement;
    private readonly InputAction m_Player_Map_Movement2;
    private readonly InputAction m_Player_Map_Jump;
    private readonly InputAction m_Player_Map_Jump2;
    public struct Player_MapActions
    {
        private @Player1Actions m_Wrapper;
        public Player_MapActions(@Player1Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Map_Movement;
        public InputAction @Movement2 => m_Wrapper.m_Player_Map_Movement2;
        public InputAction @Jump => m_Wrapper.m_Player_Map_Jump;
        public InputAction @Jump2 => m_Wrapper.m_Player_Map_Jump2;
        public InputActionMap Get() { return m_Wrapper.m_Player_Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_MapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_MapActions instance)
        {
            if (m_Wrapper.m_Player_MapActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement;
                @Movement2.started -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement2;
                @Movement2.performed -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement2;
                @Movement2.canceled -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnMovement2;
                @Jump.started -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnJump;
                @Jump2.started -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnJump2;
                @Jump2.performed -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnJump2;
                @Jump2.canceled -= m_Wrapper.m_Player_MapActionsCallbackInterface.OnJump2;
            }
            m_Wrapper.m_Player_MapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Movement2.started += instance.OnMovement2;
                @Movement2.performed += instance.OnMovement2;
                @Movement2.canceled += instance.OnMovement2;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Jump2.started += instance.OnJump2;
                @Jump2.performed += instance.OnJump2;
                @Jump2.canceled += instance.OnJump2;
            }
        }
    }
    public Player_MapActions @Player_Map => new Player_MapActions(this);
    public interface IPlayer_MapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMovement2(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnJump2(InputAction.CallbackContext context);
    }
}
