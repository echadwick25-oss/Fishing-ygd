using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using TMPro;

public class FishingMinigame_Input : MonoBehaviour
{
    public enum State {  Idle, WaitingForBite, Running, Result }

    [Header("References")]
    public RectTransform trackArea;
    public RectTransform marker;
    public RectTransform successZone;
    public TMP_Text resultText;


    [Header("Gameplay")]
    public float speed = 1.5f;
    public Vector2 biteWaitRange = new Vector2(0.75f, 1.75f);
    public bool randomizeZone = true;
    public Vector2 zoneSizeRange = new Vector2(0.18f, 0.32f);
    public Vector2 zoneCenterClamp = new Vector2(0.15f, 0.85f);
    public bool autoStartOnEnable = true;

    [Header("Input (new Input System")]
    [Tooltip("Assign an InputActionReference to a Button-type action")]
    public InputActionReference stopAction;

    [Header("Events")]
    public UnityEvent onCatch;
    public UnityEvent onMiss;

    public State state = State.Idle;
    private float t;
    private int dir = 1;
    private float biteTimer;

    private void OnEnable()
    {
        if (stopAction != null && stopAction.action != null)
        {
            stopAction.action.performed += OnStopPerformed;
            stopAction.action.Enable();
        }

        if (autoStartOnEnable) StartFishing();
    }
}
