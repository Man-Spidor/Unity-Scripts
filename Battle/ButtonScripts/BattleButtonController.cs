using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButtonController : MonoBehaviour {
    [SerializeField] BattleDialogueBox dialogueBox;

    private List<Ability> abilities;
    private bool clicked = false;
    
    public void setDetails(List<Ability> _abilities) {
        abilities = _abilities;
    }
    public void fightClicked() {
        dialogueBox.EnableAbilitySelector(true);
        dialogueBox.EnableActionSelector(false);
        dialogueBox.EnableDialogueText(false);
    }

    public void runClicked() {
        Debug.Log("Run");
    }

    public void move1Clicked() {
        clicked = !clicked;
        if(!clicked) {
            Debug.Log("Move1");
        }
        Debug.Log(abilities[0].Base.getDesc());    
        dialogueBox.setDetailText(abilities[0].Base.getDesc(), abilities[0].Base.getCool());
        dialogueBox.EnableAbilityDetails(true);
    }
    
    public void move2Clicked() {
        Debug.Log("Move2");
    }
    
    public void move3Clicked() {
        Debug.Log("Move3");
    }
    
    public void move4Clicked() {
        Debug.Log("Move4");
    }
}