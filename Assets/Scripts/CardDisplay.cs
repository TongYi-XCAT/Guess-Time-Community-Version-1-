using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI erosionText;
    public TextMeshProUGUI luckyText;
    public TextMeshProUGUI skillText;
    public TextMeshProUGUI damageText;
    public TextMeshProUGUI defenseText;
    public TextMeshProUGUI effectText;
    public TextMeshProUGUI erosionAccumulationText;
    public TextMeshProUGUI noteText;
    public TextMeshProUGUI typeText;
    public Image backgroundImage;
    public Card card;
    // Start is called before the first frame update
    void Start()
    {
        ShowCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowCard()
    {
        nameText.text = card.cardName;
        if(card is CharacterCard ) //��ɫ����ʾ
        {
            var character = card as CharacterCard;
            healthText.text = "Ѫ��"+character.health.ToString();
            erosionText.text="��ʴ��"+character.erosion.ToString();
            luckyText.text="���ˣ�"+character.lucky.ToString();
            skillText.text="���ܣ�"+character.skill;
        }
        else if(card is BasicActionCard) //��������ʾ
        {
            var basicAction = card as BasicActionCard;
            damageText.text = "�˺���" + basicAction.damage.ToString();
            defenseText.text = "������" + basicAction.defense.ToString();
            erosionAccumulationText.text=basicAction.erosionAccumulation.ToString();
            noteText.text = basicAction.note;
        }
        else if(card is EffectCard) //Ч������ʾ
        {
            var effect = card as EffectCard;
            erosionAccumulationText.text= effect.erosionAccumulation.ToString();
            typeText.text = "<" + effect.type + ">";
            effectText.text=effect.effect;
            noteText.text = effect.note;
        }
    }
}
