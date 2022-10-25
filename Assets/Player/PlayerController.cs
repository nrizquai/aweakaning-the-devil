//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Player/PlayerController.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerController : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""movement"",
            ""id"": ""af85568d-4915-4a50-89af-f266e925882e"",
            ""actions"": [
                {
                    ""name"": ""LeftStickLR"",
                    ""type"": ""Value"",
                    ""id"": ""bb2c4791-8e93-44a2-b2df-07dadf1fc9ac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftStickDU"",
                    ""type"": ""Button"",
                    ""id"": ""bc981254-7c8d-4373-8cee-d164e9de2e20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""d5e795dd-9edf-43f1-8e30-aa4083b4f64d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""b22473a9-e7df-459d-96f2-4c8285bedd7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""8f0f4134-fd0f-4048-8b0a-817213445c94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""f844a3e0-2e5f-4d4f-8a30-9f0ef7d4747d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lock"",
                    ""type"": ""Button"",
                    ""id"": ""3351bf39-16ed-40aa-b981-b6c5a0211bb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a1590e8a-fc68-409d-8caa-388c21b21029"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MoveLR"",
                    ""id"": ""39c6419e-6d4c-4655-8f17-518748294c85"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1ffdadff-3f96-4246-969d-403be88b8134"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c4a535b3-5d21-479d-b874-c644962761bd"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""clav"",
                    ""id"": ""9ee38522-f818-43b8-9c8a-adaeade1f05d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b90174e4-a489-4f82-892e-81e973e4f1c8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6c6be7cd-52bf-427e-bbea-a67f3c94e295"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""MoveDU"",
                    ""id"": ""793d786a-acb4-4c5a-a581-a82524a1b0b7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickDU"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e68f0c50-6b64-4661-aa17-9f7a87df44c2"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickDU"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""efb976ef-74bc-424f-9407-9e54d09f3097"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickDU"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""clav"",
                    ""id"": ""dc1c0eb2-c526-4ec1-9b37-d9b10f3121e3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickDU"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5bbb2c44-fb87-4b2a-8318-753c8b9b35ed"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickDU"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f8f8e4e6-de4a-4e5e-a483-4fd895e04509"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickDU"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""483f3250-25c8-491c-a5cf-f9002d424ab0"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4177a809-db7f-4c21-b1bc-656542f232c7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""613e27c8-ac9f-4ef3-ad1e-32521de6aadd"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f72d0f6-d1c1-4fec-877b-c4d8f46350df"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a202fec6-0528-4745-baa1-0c2a49ac831c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67a7d24b-3197-47f6-b8ee-398c4bb740f3"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""11fc1471-d458-45ee-995f-03ec8918e789"",
            ""actions"": [
                {
                    ""name"": ""NavigateH"",
                    ""type"": ""Value"",
                    ""id"": ""ed6723ef-7de3-4e65-98eb-f1a192218c75"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""NavigateV"",
                    ""type"": ""Value"",
                    ""id"": ""0924ce7a-ff68-4df0-89fa-75e1e12efcaa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""3719d673-b8e4-461f-98a8-40567fac2e68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""36a77155-3764-48fc-b874-3a1a2c5a70f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""2857b01a-d032-46ab-8dbb-a026516b0393"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""370fe222-a275-463b-b9a5-eaa8c43c78ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Left/Right"",
                    ""id"": ""1d4a2199-ce76-4197-be05-a0e3ef0eaec9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateH"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""914e3d0c-1d7c-4884-8929-76357cc31297"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c8a46e9b-cef8-4584-a51d-3c4d4718d2cc"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Up/Down"",
                    ""id"": ""e8232a8f-1daa-4d31-8fdd-363fa2531e1f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b7505d8c-1c51-43eb-9c29-66a89b3275bf"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dfe38720-22a1-4f60-8507-e8aa9ff52da7"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f44059b2-296d-45d3-bc7c-e59eb861de98"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed3cb1cb-ca8c-4197-ae81-7ba6e4842d08"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d53c6ad0-ce7e-41bf-85ff-2eda7a26add6"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68c1fc7e-cb18-4cf7-b5a8-477c708d88c8"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // movement
        m_movement = asset.FindActionMap("movement", throwIfNotFound: true);
        m_movement_LeftStickLR = m_movement.FindAction("LeftStickLR", throwIfNotFound: true);
        m_movement_LeftStickDU = m_movement.FindAction("LeftStickDU", throwIfNotFound: true);
        m_movement_A = m_movement.FindAction("A", throwIfNotFound: true);
        m_movement_B = m_movement.FindAction("B", throwIfNotFound: true);
        m_movement_X = m_movement.FindAction("X", throwIfNotFound: true);
        m_movement_Y = m_movement.FindAction("Y", throwIfNotFound: true);
        m_movement_Lock = m_movement.FindAction("Lock", throwIfNotFound: true);
        m_movement_Pause = m_movement.FindAction("Pause", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_NavigateH = m_UI.FindAction("NavigateH", throwIfNotFound: true);
        m_UI_NavigateV = m_UI.FindAction("NavigateV", throwIfNotFound: true);
        m_UI_A = m_UI.FindAction("A", throwIfNotFound: true);
        m_UI_B = m_UI.FindAction("B", throwIfNotFound: true);
        m_UI_X = m_UI.FindAction("X", throwIfNotFound: true);
        m_UI_Y = m_UI.FindAction("Y", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // movement
    private readonly InputActionMap m_movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_movement_LeftStickLR;
    private readonly InputAction m_movement_LeftStickDU;
    private readonly InputAction m_movement_A;
    private readonly InputAction m_movement_B;
    private readonly InputAction m_movement_X;
    private readonly InputAction m_movement_Y;
    private readonly InputAction m_movement_Lock;
    private readonly InputAction m_movement_Pause;
    public struct MovementActions
    {
        private @PlayerController m_Wrapper;
        public MovementActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftStickLR => m_Wrapper.m_movement_LeftStickLR;
        public InputAction @LeftStickDU => m_Wrapper.m_movement_LeftStickDU;
        public InputAction @A => m_Wrapper.m_movement_A;
        public InputAction @B => m_Wrapper.m_movement_B;
        public InputAction @X => m_Wrapper.m_movement_X;
        public InputAction @Y => m_Wrapper.m_movement_Y;
        public InputAction @Lock => m_Wrapper.m_movement_Lock;
        public InputAction @Pause => m_Wrapper.m_movement_Pause;
        public InputActionMap Get() { return m_Wrapper.m_movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @LeftStickLR.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeftStickLR;
                @LeftStickLR.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeftStickLR;
                @LeftStickLR.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeftStickLR;
                @LeftStickDU.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeftStickDU;
                @LeftStickDU.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeftStickDU;
                @LeftStickDU.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeftStickDU;
                @A.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnY;
                @Lock.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLock;
                @Lock.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLock;
                @Lock.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLock;
                @Pause.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftStickLR.started += instance.OnLeftStickLR;
                @LeftStickLR.performed += instance.OnLeftStickLR;
                @LeftStickLR.canceled += instance.OnLeftStickLR;
                @LeftStickDU.started += instance.OnLeftStickDU;
                @LeftStickDU.performed += instance.OnLeftStickDU;
                @LeftStickDU.canceled += instance.OnLeftStickDU;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @Lock.started += instance.OnLock;
                @Lock.performed += instance.OnLock;
                @Lock.canceled += instance.OnLock;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MovementActions @movement => new MovementActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_NavigateH;
    private readonly InputAction m_UI_NavigateV;
    private readonly InputAction m_UI_A;
    private readonly InputAction m_UI_B;
    private readonly InputAction m_UI_X;
    private readonly InputAction m_UI_Y;
    public struct UIActions
    {
        private @PlayerController m_Wrapper;
        public UIActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @NavigateH => m_Wrapper.m_UI_NavigateH;
        public InputAction @NavigateV => m_Wrapper.m_UI_NavigateV;
        public InputAction @A => m_Wrapper.m_UI_A;
        public InputAction @B => m_Wrapper.m_UI_B;
        public InputAction @X => m_Wrapper.m_UI_X;
        public InputAction @Y => m_Wrapper.m_UI_Y;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @NavigateH.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateH;
                @NavigateH.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateH;
                @NavigateH.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateH;
                @NavigateV.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateV;
                @NavigateV.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateV;
                @NavigateV.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateV;
                @A.started -= m_Wrapper.m_UIActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_UIActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_UIActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_UIActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnY;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NavigateH.started += instance.OnNavigateH;
                @NavigateH.performed += instance.OnNavigateH;
                @NavigateH.canceled += instance.OnNavigateH;
                @NavigateV.started += instance.OnNavigateV;
                @NavigateV.performed += instance.OnNavigateV;
                @NavigateV.canceled += instance.OnNavigateV;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IMovementActions
    {
        void OnLeftStickLR(InputAction.CallbackContext context);
        void OnLeftStickDU(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnLock(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigateH(InputAction.CallbackContext context);
        void OnNavigateV(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
    }
}
