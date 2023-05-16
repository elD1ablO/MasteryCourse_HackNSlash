using UnityEngine;

public class UICharacterSelectionMenu : MonoBehaviour
{
    [SerializeField] private UICharacterSelectionPanel vikingPanel;
    [SerializeField] private UICharacterSelectionPanel wizardPanel;

    public UICharacterSelectionPanel VikingPanel { get { return vikingPanel; } }
    public UICharacterSelectionPanel WizardPanel { get { return wizardPanel; } }
}
