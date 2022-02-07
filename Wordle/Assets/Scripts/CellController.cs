using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CellController : MonoBehaviour
{
    [SerializeField] Color colorNone;
    [SerializeField] Color colorPresent;
    [SerializeField] Color colorCorrect;
    [SerializeField] Color colorAbsent;
    [SerializeField] private Image background;
    [SerializeField] private TextMeshProUGUI text;

    public void UpdateText(char msg) {
        text.SetText(msg.ToString());
    }

    public void UpdateState(StateType state){
        background.color = GetColor(state);
    }
    private Color GetColor(StateType state){
        return state switch{
            StateType.None => colorNone,
            StateType.Present => colorPresent,
            StateType.Correct => colorCorrect,
            StateType.Absent => colorAbsent,
        };
    }

}

public enum StateType{
    None,
    Present,
    Correct,
    Absent
}